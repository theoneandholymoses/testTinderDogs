using System.Text.RegularExpressions;

namespace testTinderDogs
{
    public class Dog
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Enum Type { get; set; }
        public Enum Size { get; set; }
        public bool Geneder { get; set; }
        public DateTime Birthdate { get; set; }
        public List<Gallery> Images { get; set; }
        public string Address { get; set; }
        public decimal lon { get; set; }
        public decimal lat { get; set; }
        public bool Vaccinated { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Match> Matches { get; set; }
        public List<Park> FavParks { get; set; }
        public List<Chat> Chats { get; set; }
    }
}
