using plannymall_api.Models;

namespace plannymall_api.Interfaces.Models
{
    public interface IPostgresUser
    {
        public Task<bool> InsertUserAsync(User cmd);

        public Task<User?> GetUserByUsernameAsync(string username);

        public Task<User?> GetUserByEmailAsync(string email);

        public Task<User?> GetUserByIdAsync(int Id);
    }
}
