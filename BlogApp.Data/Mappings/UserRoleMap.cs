using BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("5BA1E7D3-2988-4FE9-A27A-711F5B0D6F55"),
                RoleId = Guid.Parse("A1811FF0-8FC3-431E-9A74-456A40DB9F2B")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("44CFC968-3A34-4B83-8104-57723FC261D9"),
                RoleId = Guid.Parse("23F307EB-F43D-4FF5-8560-A77B4ADFDA9D")
            });
        }
    }
}
