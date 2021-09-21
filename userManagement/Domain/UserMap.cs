using Microsoft.EntityFrameworkCore.Metadata.Builders;//fluent api
namespace userManagement.Domain
{
    public class UserMap
    {
       public UserMap(EntityTypeBuilder<User> user)
       {
          user.HasKey(t=>t.Id);
          user.Property(t=>t.Email).IsRequired();
          user.Property(t=>t.Password).IsRequired();
          user.HasOne(t=>t.userProfile).WithOne(t=>t.user).HasForeignKey<UserProfile>(t=>t.Id);//One To One Relationship.
       } 
    }
}