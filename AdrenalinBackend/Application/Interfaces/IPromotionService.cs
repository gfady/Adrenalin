using Domain.DTOs.Promotion;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IPromotionService
    {
        Task<List<Promotion>> GetPromotions();
        Task<Promotion> CreatePromotion(PromotionCreateDTO promotionDto);
    }
}
