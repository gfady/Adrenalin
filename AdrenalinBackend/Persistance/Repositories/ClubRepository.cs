using Domain.Interfaces;
using Domain.Models;
using Persistance.Data;
using Persistance.Repositories.Base;

namespace Persistance.Repositories
{
    public class ClubRepository : BaseRepository<Club, DatabaseContext>, IClubRepository
    {
        public ClubRepository(DatabaseContext context) : base(context) { }
    }
}
