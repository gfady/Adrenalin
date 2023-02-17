using Domain.Interfaces;
using Domain.Models;
using Persistance.Data;
using Persistance.Repositories.Base;

namespace Persistance.Repositories
{
    public class UserRepository : BaseRepository<User, DatabaseContext>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context) { }
    }
}
