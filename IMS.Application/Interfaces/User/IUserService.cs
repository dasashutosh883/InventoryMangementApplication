using IMS.Domain.Entities;

namespace IMS.Application.Interfaces.User
{
    public interface IUserService
    {
        Task<IEnumerable<Users>> GetAllUsersAsync();
        Task<Users> GetUserByIdAsync(int id);
        Task<bool> CreateUserAsync(Users User);
        Task<bool> UpdateUserAsync(Users User);
        Task<bool> DeleteUserAsync(int id);
        Task<bool> Login(Users user, out string statuscode, out int id);
    }
}
