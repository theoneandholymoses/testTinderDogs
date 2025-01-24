namespace testTinderDogs.Core.Models
{
    public class Image
    {
        public string Id { get; set; }
        public Dog DogId { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
    }
}
