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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("FD2E4A58-7C07-4619-AA49-2573E7B1D441"),
                Name = ".NET Architecture",
                CreatedBy = "Admin User",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("9B099245-E598-42E4-AD35-2673B4F4F090"),
                Name = "MERN Stack Apps",
                CreatedBy = "Admin User",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
