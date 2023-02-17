using Application.Interfaces;
using AutoMapper;
using Domain.DTOs.New;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class NewService : INewService
    {

        private readonly IRepositoryManager manager;
        private readonly IMapper mapper;
        public NewService(IRepositoryManager manager, IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }

        public async Task<New> CreateNew(NewCreateDTO newDto)
        {
            var newToCreate = mapper.Map<New>(newDto);
            newToCreate.Id = Guid.NewGuid().ToString();

            var created = await manager.NewRepository.AddAsync(newToCreate);
            await manager.CommitAsync();
            return created;
        }

        public async Task<List<New>> GetAllNews()
        {
            var news = await manager.NewRepository.GetAllAsync();
            return news;
        }
    }
}
