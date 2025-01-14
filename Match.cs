namespace testTinderDogs
{
    public class Match
    {
        public string FromDog {  get; set; }
        public string ToDog { get; set; }
        public bool IsLike { get; set; }
        public bool IsMatch { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
