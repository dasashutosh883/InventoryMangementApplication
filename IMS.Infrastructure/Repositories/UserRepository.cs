using Dapper;
using IMS.Domain.Entities;
using IMS.Domain.Repositories;
using IMS.Infrastructure.Base;
using IMS.Infrastructure.Context;
using System.Data;
using static Dapper.SqlMapper;

namespace IMS.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IDapperContext connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<bool> AddAsync(Users entity)
        {
            var param = new DynamicParameters();
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            _ = await Connection.ExecuteAsync("", param, commandType: CommandType.StoredProcedure);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var param = new DynamicParameters();
            param.Add("", id);
            _ = await Connection.ExecuteAsync("", param, commandType: CommandType.StoredProcedure);
            return true;
        }

        public async Task<IEnumerable<Users>> GetAllAsync()
        {
            var param = new DynamicParameters();
            var result = await Connection.QueryAsync<Users>("", param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<Users> GetByIdAsync(int id)
        {
            var param = new DynamicParameters();
            var result = await Connection.QueryFirstOrDefaultAsync<Users>("", param, commandType: CommandType.StoredProcedure);
            return result!;
        }

        public Task<bool> Login(Users user, out string statuscode, out int id)
        {
            var param = new DynamicParameters();
            param.Add("", user.MobileNumber);
            param.Add("", user.PasswordHash);
            param.Add("@StatusCode", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            param.Add("@UserId", dbType: DbType.Int32, direction: ParameterDirection.Output);
            Connection.ExecuteAsync("", param, commandType: CommandType.StoredProcedure);
            statuscode = param.Get<string>("@StatusCode");
            id = param.Get<int>("@UserId");
            if(id == 0)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Users entity)
        {
            var param = new DynamicParameters();
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            param.Add("", entity.FullName);
            _ = await Connection.ExecuteAsync("", param, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
