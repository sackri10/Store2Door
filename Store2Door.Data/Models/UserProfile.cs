namespace Store2Door.Data.Models
{
    public class UserProfile :BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public virtual User User { get; set; }
        
    }
}