namespace testTinderDogs
{
    public class Messege
    {
        public string Id { get; set; }
        public string ChatID { get; set; }
        public bool FromDogToDog { get; set; }
        public string Content {  get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
