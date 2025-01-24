using testTinderDogs.Core.Models;

namespace testTinderDogs.Core.Interfaces
{
    public interface IDogRepository
    {
        public Task<Dog?> CreateDogAsync(User user);
        public Task<Dog?> GetDogByIdAsync(string id);
        public Task<Dog?> UpdateDogByIdAsync(string id);
        public Task<Dog?> DeleteDogByIdAsync(string id);
        public Task<Match?> CreateNewMatch(string id);



    }
}
