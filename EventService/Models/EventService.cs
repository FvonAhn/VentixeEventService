namespace EventService.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
