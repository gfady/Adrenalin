using Domain.Interfaces;
using Domain.Models;
using Persistance.Data;
using Persistance.Repositories.Base;

namespace Persistance.Repositories
{
    public class VisitRepository : BaseRepository<Visit, DatabaseContext>, IVisitRepository
    {
        public VisitRepository(DatabaseContext context) : base(context) { }
    }
}
