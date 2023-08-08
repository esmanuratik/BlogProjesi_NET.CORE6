using Blog_DATA.UnitOfWorks;
using Blog_ENTİTY.Entities;
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


        //burada repositorylere idrek olarak erişmeyeceğiz.Erişmeyeceğimiz için de hata alıp alamadığımız bilemeyeceğimiz için  UnitOfWork yapısını kullanmıştık buarda da yine aynı şekilde CTOR da unitofwork yapısını kullancağım. 

        private readonly IUnitOfWork unitOfWork;
        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
