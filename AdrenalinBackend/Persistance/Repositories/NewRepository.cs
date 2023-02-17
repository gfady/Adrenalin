using Domain.Interfaces;
using Domain.Models;
using Persistance.Data;
using Persistance.Repositories.Base;

namespace Persistance.Repositories
{
    public class NewRepository : BaseRepository<New, DatabaseContext>, INewRepository
    {
        public NewRepository(DatabaseContext context) : base(context) { }
    }
}
