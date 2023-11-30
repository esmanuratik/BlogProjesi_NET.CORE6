using AutoMapper;
using Blog_DATA.UnitOfWorks;
using Blog_ENTİTY.Entities;
using Blog_ENTİTY.ViewModels.Articles;
using Blog_SERVİCE.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_SERVİCE.Services.Concrete
{
    public class ArticleService : IArticleService
    {


        //burada repositorylere direk olarak erişmeyeceğiz.Erişmeyeceğimiz için de hata alıp alamadığımız bilemeyeceğimiz için  UnitOfWork yapısını kullanmıştık burada da yine aynı şekilde CTOR da unitofwork yapısını kullancağım. 

        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }      

        public async Task<List<ArticlesViewModel>> GetAllArticlesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticlesViewModel>>(articles);

            return map; 
        }
    }
}
