using Application.Interfaces;
using AutoMapper;
using Domain.DTOs.Promotion;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IRepositoryManager manager;
        private readonly IMapper mapper;
        public PromotionService(IRepositoryManager manager, IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }

        public async Task<Promotion> CreatePromotion(PromotionCreateDTO promotionDto)
        {
            var promotion = mapper.Map<Promotion>(promotionDto);
            promotion.Id = Guid.NewGuid().ToString();

            var created = await manager.Promotion.AddAsync(promotion);
            await manager.CommitAsync();
            return created;
        }

        public async Task<List<Promotion>> GetPromotions()
        {
            var promotionList = await manager.Promotion.GetAllAsync();
            return promotionList;
        }
    }
}
