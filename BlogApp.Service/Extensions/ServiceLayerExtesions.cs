using BlogApp.Data.Context;
using BlogApp.Data.Repositories.Abstractions;
using BlogApp.Data.Repositories.Concretes;
using BlogApp.Data.UnitOfWorks;
using BlogApp.Service.Services.Abstractions;
using BlogApp.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Service.Extensions
{
    public static class ServiceLayerExtesions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
