namespace TaskSchedulerApp.Models
{
    public class Prayer
    {
        public int Id { get; set; }
        public string PrayerName { get; set; }  // This is the correct property name
        public TimeSpan Time { get; set; }
    }
}
