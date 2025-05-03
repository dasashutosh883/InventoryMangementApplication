using IMS.Domain.Repositories;
using IMS.Infrastructure.Context;

namespace IMS.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private readonly IDapperContext _connectionFactory;
        private UserRepository _user;
        public UnitOfWork(IDapperContext connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IUserRepository user => _user ??= new UserRepository(_connectionFactory);

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_user is IDisposable disposableRepo)
                        disposableRepo.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
