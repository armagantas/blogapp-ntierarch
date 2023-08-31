using AutoMapper;
using BlogApp.Data.UnitOfWorks;
using BlogApp.Entity.DTOs.Articles;
using BlogApp.Entity.Entities;
using BlogApp.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticlesAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = _mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}
