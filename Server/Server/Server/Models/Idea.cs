namespace Server.Models
{
    public class Idea
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ActivityType { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public int DurationMinutes { get; set; }
        public string Status { get; set; } = string.Empty;

    }
}
