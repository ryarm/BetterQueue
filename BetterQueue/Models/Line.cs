namespace BetterQueue.Models
{
    public class Line
    {
        public int LineID { get; set; }
        public int LocationID { get; set; }
        public string LineName { get; set; }
        public int LineCapacity { get; set; }
        public TimeOnly ShutoffTime { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
