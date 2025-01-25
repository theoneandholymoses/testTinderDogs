namespace testTinderDogs.Core.Models
{
    public class Park
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal lon { get; set; }
        public decimal lat { get; set; }
        public ICollection<Dog> DogLikes { get; set; } = new List<Dog>();
        //public ICollection<Image> Images { get; set; } = new List<Image>();
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
