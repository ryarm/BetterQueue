namespace BetterQueue.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? AssignedUserID { get; set; }
        public string Status { get; set; }
        public string ServiceType { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
        public int LineID { get; set; }

        public string FullName()
        { 
            return FirstName + " " + LastName;
        }
    }
}
