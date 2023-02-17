using Domain.DTOs.New;
using Domain.Models;

namespace Application.Interfaces
{
    public interface INewService
    {
        Task<List<New>> GetAllNews();
        Task<New> CreateNew(NewCreateDTO newDto);
    }
}
