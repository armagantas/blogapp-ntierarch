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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = ".Net Core Clean Architecture",
                Content = "Clean Architecture style focus on a loosely coupled implementation of use cases. Use cases as central organizing structure, decoupled from frameworks and technology details.",
                ViewCount = 15,
                CategoryId = Guid.Parse("FD2E4A58-7C07-4619-AA49-2573E7B1D441"),
                ImageId = Guid.Parse("26D92493-2674-4424-BA1D-1159697D7C03"),
                CreatedBy = "Admin User",
                CreatedDate = DateTime.Now,
                UserId = Guid.Parse("5BA1E7D3-2988-4FE9-A27A-711F5B0D6F55")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Node.js & React Full-Stack Web Application",
                Content = "React is a popular front-end JavaScript library for creating interactive user interfaces. Node.js, on the other hand, is a server-side JavaScript environment that lets developers build scalable web applications with high performance and low latency.",
                ViewCount = 10,
                CategoryId = Guid.Parse("9B099245-E598-42E4-AD35-2673B4F4F090"),
                ImageId = Guid.Parse("B74D71EF-E944-486A-BA69-5B33A6C12F5A"),
                CreatedBy = "Admin User",
                CreatedDate = DateTime.Now,
                UserId = Guid.Parse("44CFC968-3A34-4B83-8104-57723FC261D9")
            });
        }
    }
}
