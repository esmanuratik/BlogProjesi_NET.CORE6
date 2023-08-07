using Blog_CORE.Entities;
using Blog_DATA.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.UnitOfWorks
{
    public interface IUnitOfWork :IAsyncDisposable
    {
        //Buradaki metotları kendimiz oluşturduk isimlendirdik ve yazdık
        IRepository<T> GetRepository<T>() where T:class,IEntityBase,new() ;
        //Burada her entity için ayrı ayrı repositroy de oluşturup yazabilirdin fakat buna gerek yok burada olduğu generic bir şekilde yapılacak.
        Task<int> SaveAsync();
        int Save();//Async olarak yazılamayan metotlar için de bunu kullanacağım
    }
}
