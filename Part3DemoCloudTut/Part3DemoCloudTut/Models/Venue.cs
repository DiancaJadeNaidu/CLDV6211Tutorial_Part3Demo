namespace Part3DemoCloudTut.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime DateAvailable { get; set; }

        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
    }
}
