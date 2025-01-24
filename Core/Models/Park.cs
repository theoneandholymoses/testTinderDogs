namespace testTinderDogs.Core.Models
{
    public class Park
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal lon { get; set; }
        public decimal lat { get; set; }
        public List<Dog> DogLikes { get; set; }
        public List<Image> Images { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
