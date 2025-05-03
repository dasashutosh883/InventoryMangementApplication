using IMS.Application.Interfaces.User;
using IMS.Domain.Entities;
using IMS.Domain.Repositories;

namespace IMS.Application.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> CreateUserAsync(Users User)
        {
            return await _unitOfWork.user.AddAsync(User);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _unitOfWork.user.DeleteAsync(id);
        }

        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            return await _unitOfWork.user.GetAllAsync();
        }

        public async Task<Users> GetUserByIdAsync(int id)
        {
            return await _unitOfWork.user.GetByIdAsync(id);
        }

        public Task<bool> Login(Users user, out string statuscode, out int id)
        {
            return _unitOfWork.user.Login(user, out statuscode, out id);
        }

        public async Task<bool> UpdateUserAsync(Users User)
        {
            return await _unitOfWork.user.UpdateAsync(User);
        }
    }
}
