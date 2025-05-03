using IMS.Domain.Entities;

namespace IMS.Domain.Repositories
{
    public interface IUserRepository : IGenericRepository<Users>
    {
        Task<bool> Login(Users user, out string statuscode, out int id);
    }
}
