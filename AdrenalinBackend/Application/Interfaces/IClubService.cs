using Domain.DTOs.Club;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IClubService
    {
        Task<List<Club>> GetAllClubs();
        Task<List<Club>> GetAllClubsByCity(string city);
        Task<Club> CreateClub(ClubCreateDTO clubDto);
    }
}
