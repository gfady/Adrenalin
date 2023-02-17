using Application.Interfaces;
using Domain.DTOs.Visit;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitController : Controller
    {
        private readonly IVisitService service;
        public VisitController(IVisitService service)
        {
            this.service = service;
        }

        [HttpPost(nameof(CreateNewVisit))]
        [AllowAnonymous]
        [Produces("application/json")]
        public async Task<ActionResult> CreateNewVisit([FromBody]VisitCreateDTO visitDto)
        {
            if (!ModelState.IsValid) return BadRequest("Passed data is invalid");

            var created = await service.CreateVisit(visitDto);
            return Ok(created);
        }
    }
}
