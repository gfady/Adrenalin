using Application.Interfaces;
using Domain.DTOs.Promotion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromotionController : Controller
    {
        private readonly IPromotionService service;
        public PromotionController(IPromotionService service)
        {
            this.service = service;
        }

        [HttpGet(nameof(GetAllPromotions))]
        [AllowAnonymous]
        public async Task<ActionResult> GetAllPromotions()
        {
            var promotions = await service.GetPromotions();

            if (!promotions.Any()) return Ok("Nothing was found");

            return Ok(promotions);
        }

        [HttpPost(nameof(CreatePromotion))]
        [AllowAnonymous]
        public async Task<ActionResult> CreatePromotion([FromBody] PromotionCreateDTO promotionDto)
        {
            if (!ModelState.IsValid) return BadRequest("Passed data is invalid");

            var created = await service.CreatePromotion(promotionDto);
            return Ok(created);
        }
    }
}
