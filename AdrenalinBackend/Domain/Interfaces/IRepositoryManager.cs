namespace Domain.Interfaces
{
    public interface IRepositoryManager : IDisposable
    {
        IClubRepository Club { get; }
        INewRepository NewRepository { get; }
        IPromotionRepository Promotion { get; }
        IUserRepository User { get; }
        IVisitRepository Visit { get; }
        Task CommitAsync();
    }
}
