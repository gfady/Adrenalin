using Application.Interfaces;
using Domain.DTOs.New;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewController : Controller
    {
        private readonly INewService service;
        public NewController(INewService service)
        {
            this.service = service;
        }

        [HttpGet(nameof(GetAllNews))]
        [AllowAnonymous]
        public async Task<ActionResult> GetAllNews()
        {
            var news = await service.GetAllNews();

            if (!news.Any()) return Ok("Nothing was found");

            return Ok(news);
        }

        [HttpPost(nameof(CreateNew))]
        [AllowAnonymous]
        public async Task<ActionResult> CreateNew([FromBody] NewCreateDTO newDto)
        {
            if (!ModelState.IsValid) return BadRequest("Passed data is invalid");

            var created = await service.CreateNew(newDto);
            return Ok(created);
        }

        //[HttpGet(nameof(GetRole))]
        //[Authorize(Roles = "admin")] 
        //public async Task<ActionResult> GetRole()
        //{
        //    var identity = HttpContext.User.Identity as ClaimsIdentity;

        //    if(identity != null)
        //    {
        //        var userClaims = identity.Claims;
        //        return Ok(userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value);

        //    }

        //    return BadRequest();
        //}
    }
}
