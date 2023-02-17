using Application.Interfaces;
using Domain.DTOs.Club;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : Controller
    {
        private readonly IClubService service;

        public ClubController(IClubService service)
        {
            this.service = service;
        }

        [HttpGet(nameof(GetAllClubs))]
        [AllowAnonymous]
        public async Task<ActionResult> GetAllClubs()
        {
            var clubs = await service.GetAllClubs();

            if (!clubs.Any()) return Ok("Nothing was found");

            return Ok(clubs);
        }

        [HttpGet("GetAllClubsByCity/{city}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetAllClubsByCity([FromRoute] string city)
        {
            if (!ModelState.IsValid) return BadRequest("Passed data is invalid");

            var clubs = await service.GetAllClubsByCity(city);

            if (!clubs.Any()) return Ok("Nothing was found");

            return Ok(clubs);
        }

        [HttpPost(nameof(CreateClub))]
        [AllowAnonymous]
        public async Task<ActionResult> CreateClub([FromBody] ClubCreateDTO clubDto)
        {
            if (!ModelState.IsValid) return BadRequest("Passed data is invalid");

            var created = await service.CreateClub(clubDto);
            return Ok(created);
        }
    }
}
