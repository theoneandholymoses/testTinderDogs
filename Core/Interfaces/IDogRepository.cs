using testTinderDogs.Core.Models;

namespace testTinderDogs.Core.Interfaces
{
    public interface IDogRepository
    {
        public Task<Dog?> CreateDog(User user);
        public Task<List<Dog?>> GetAllDogs(User user);
        public Task<List<Dog?>> GetAllUserDogs(User user);
        // return all new dogs that this dog didn't like/ unlike
        public Task<List<Dog?>> GetUnMatchedDogs(User user);
        public Task<Dog?> GetDogById(string id);
        public Task<Dog?> UpdateDog(string id);
        public Task<Dog?> DeleteDog(string id);

    }
}
