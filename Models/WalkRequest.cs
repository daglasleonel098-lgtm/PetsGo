namespace PetsGo.Models
{
    public class WalkRequest
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Status { get; set; } // Pending, Accepted, Rejected
    }
}
