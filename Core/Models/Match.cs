namespace testTinderDogs.Core.Models
{
    public class Match
    {
        public string FromDogId { get; set; }
        public Dog FromDog { get; set; }
        public string ToDogId { get; set; }
        public Dog ToDog { get; set; }
        public bool IsLike { get; set; }
        public bool IsMatch { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
