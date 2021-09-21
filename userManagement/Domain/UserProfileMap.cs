using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace userManagement.Domain
{
    public class UserProfileMap
    {
       public UserProfileMap(EntityTypeBuilder<UserProfile> entityBuilder)
       {
        entityBuilder.HasKey(t=>t.Id);
        entityBuilder.Property(t=>t.FirstName).IsRequired();
        entityBuilder.Property(t=>t.LastName).IsRequired();
       } 
    }
}