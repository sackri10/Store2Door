namespace Store2Door.Data.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public virtual UserProfile Profile { get; set; }

    }
}