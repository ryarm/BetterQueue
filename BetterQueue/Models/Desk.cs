namespace BetterQueue.Models
{
    public class Desk
    {
        public int DeskID { get; set; }
        public string DeskName { get; set; }
        public int UserAtDesk { get; set; }
        public int DeskLocation {  get; set; }
        public bool IsActive { get; set; } = true;
    }
}
