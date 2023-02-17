using Application.Interfaces;
using AutoMapper;
using Domain.DTOs.Visit;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class VisitService : IVisitService
    {
        private readonly IRepositoryManager manager;
        private readonly IMapper mapper;
        public VisitService(IRepositoryManager manager, IMapper mapper)
        {
            this.manager = manager;    
            this.mapper = mapper;
        }

        public async Task<Visit> CreateVisit(VisitCreateDTO visitDto)
        {
            var visit = mapper.Map<Visit>(visitDto);
            visit.Id = Guid.NewGuid().ToString();
            visit.Date = DateTime.Today.ToString("dd-MM-yyyy");
            var created = await manager.Visit.AddAsync(visit);
            await manager.CommitAsync();
            return created;
        }

    }
}
