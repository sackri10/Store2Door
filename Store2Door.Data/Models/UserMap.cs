using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Store2Door.Data.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t=>t.Email).IsRequired();
            entityBuilder.Property(t=>t.Password).IsRequired();
            entityBuilder.HasOne(t => t.Profile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}