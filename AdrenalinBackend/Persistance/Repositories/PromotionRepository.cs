using Domain.Interfaces;
using Domain.Models;
using Persistance.Data;
using Persistance.Repositories.Base;

namespace Persistance.Repositories
{
    public class PromotionRepository : BaseRepository<Promotion, DatabaseContext>, IPromotionRepository
    {
        public PromotionRepository(DatabaseContext context) : base(context) { }
    }
}
