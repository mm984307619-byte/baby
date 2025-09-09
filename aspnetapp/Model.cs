namespace aspnetapp
{
    public class Counter
    {
        public int id { get; set; }
        public int count { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
    public class Tip
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Link { get; set; }
        public string Url { get; set; }
    }
}
