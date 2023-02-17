using Domain.Interfaces;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DatabaseContext dbContext;

        public RepositoryManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private INewRepository? newRepo;
        private IPromotionRepository? promotion;
        private IClubRepository? club;
        private IUserRepository? user;
        private IVisitRepository? visit;

        public IPromotionRepository Promotion
        {
            get
            {
                if (promotion == null)
                {
                    promotion = new PromotionRepository(dbContext);
                }

                return promotion;
            }
        }

        public IVisitRepository Visit
        {
            get
            {
                if (visit == null)
                {
                    visit = new VisitRepository(dbContext);
                }

                return visit;
            }
        }

        public IClubRepository Club
        {
            get
            {
                if (club == null)
                {
                    club = new ClubRepository(dbContext);
                }

                return club;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (user == null)
                {
                    user = new UserRepository(dbContext);
                }

                return user;
            }
        }

        public INewRepository NewRepository
        {
            get
            {
                if (newRepo == null)
                {
                    newRepo = new NewRepository(dbContext);
                }

                return newRepo;
            }
        }

        public async Task CommitAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
        }
    }
}
