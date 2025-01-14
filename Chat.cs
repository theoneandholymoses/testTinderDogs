namespace testTinderDogs
{
    public class Chat
    {
        public string Id { get; set; }
        public string FromDogId { get; set; }
        public string ToDogId { get;set; }
        public Messege LastMessege { get; set; }
        public string LastMessegeUser { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateTime { get; set; }
        public List<Messege> Messeges { get; set; }
    }
}
