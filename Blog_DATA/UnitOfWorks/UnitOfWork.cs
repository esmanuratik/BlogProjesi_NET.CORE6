using Blog_DATA.Context;
using Blog_DATA.Repositories.Abstracts;
using Blog_DATA.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;//database işlemleri ile uğraşacağımız için DbContext çağırmalıyız.

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync()//IAsyncDisposible dan kalıttığımız için bu metot geldi.
        {
            await dbContext.DisposeAsync();
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()//ileride service lerle işlem yaptığımızda repository<T> sayesinde istediğimiz entity çağırıp işlem yapabileceğiz.
        {
           return new Repository<T>(dbContext);
        }
    }
}
