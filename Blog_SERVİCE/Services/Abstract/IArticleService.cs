using Blog_ENTİTY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_SERVİCE.Services.Abstract
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticlesAsync();//async işlem yaptığım için task kullandık ve getallarticleasync metodu oluşturduk.
    }
}
