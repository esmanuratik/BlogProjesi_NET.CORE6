using AutoMapper;
using Blog_ENTİTY.Entities;
using Blog_ENTİTY.ViewModels.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_SERVİCE.AutoMapper.Articles
{
    public class ArticleProfile:Profile//Profile AutoMapper ile hazır gelen sınıf
    {

        public ArticleProfile()
        {
            CreateMap<ArticlesViiewModel,ArticlesViewModel>().ReverseMap();
            //ArticleViewModel istersem Article ile Map leme işlemi yap.ReverseMap ile de Article istersem ArticleViewModel ile işlem yap.Yani kısaca bunları birbirne map leme olayı vardır.Bunu da servicde program.cs de Assembly ile belirttiğim gibi belirtmeliyim.Yani program.cs de kalablaık olmasın temiz bir kod olsun diye ServiceLayerExtensions da.
        }
    }
}
