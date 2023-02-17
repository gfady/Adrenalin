using Application.Interfaces;
using AutoMapper;
using Domain.DTOs.Club;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class ClubService : IClubService
    {
        private readonly IRepositoryManager manager;
        private readonly IMapper mapper;
        public ClubService(IRepositoryManager manager, IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }

        public async Task<List<Club>> GetAllClubs()
        {
            return await manager.Club.GetAllAsync();
        }
        public async Task<Club> CreateClub(ClubCreateDTO clubDto)
        {
            var club = mapper.Map<Club>(clubDto);
            club.Id = Guid.NewGuid().ToString();

            var created = await manager.Club.AddAsync(club);
            await manager.CommitAsync();
            return created;
        }

        public async Task<List<Club>> GetAllClubsByCity(string city)
        {
            return await manager.Club.FindAllByAsync(x => x.City == city);
        }
    }
}
