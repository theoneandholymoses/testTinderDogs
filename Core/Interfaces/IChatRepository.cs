using testTinderDogs.Core.Models;

namespace testTinderDogs.Core.Interfaces
{
    public interface IChatRepository
    {
        public Task<Chat?> CreateChatAsync(string id);
        public Task<List<Chat?>> GetAllChatsAsync(string id);
        public Task<Chat?> GetChatByIdAsync(string id);
        public Task<Chat?> UpdateChatAsync(string id);
        public Task<Chat?> DeleteChatAsync(string id);
    }
}
