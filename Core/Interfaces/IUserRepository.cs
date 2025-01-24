using testTinderDogs.Core.Models;

namespace testTinderDogs.Core.Interfaces
{
    public interface IUserRepository
    {
        public Task<User?> CreateUserAsync(User user);
        public Task<User?> GetUserByIdAsync(string id);
        public Task<List<Dog?>> GetUserAllDogsAsync(string id);
        public Task<User?> GetUserByEmailAsync(string email);
        public Task<List<User>> GetAllUsersAsync();
        public Task<User?> UpdateUserAsync(string id, User user);
        // remove all user dogs 
        public Task<User?> DeleteUserAsync(string id);
    }
}
