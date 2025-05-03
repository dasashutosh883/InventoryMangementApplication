namespace IMS.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository user { get; }
    }
}
