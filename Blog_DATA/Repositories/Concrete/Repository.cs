using Blog_CORE.Entities;
using Blog_DATA.Context;
using Blog_DATA.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.Repositories.Concrete
{
    public class Repository<T>:IRepository<T> where T : class,IEntityBase,new()
        //IEntitybase den türetilmemiş hiçbir sınıf bunu kullanmasın diye bundan kalıtıyourm ayrıca T ile bir Entity belirttiğim için bunun bir class oldugunu belirtmeliyim.
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }//bunu yapmasaydık her seferinde db contexde bunu yazmak zorunda kalırdık.


        //Bu kod, asenkron olarak çalışan bir metodu tanımlıyor. AddAsync adında bir metot, T tipindeki bir varlık (entity) nesnesini veritabanına eklemek amacıyla kullanılıyor.
        //Task: Metot, Task tipinde bir nesne döndüreceğini ifade eder. Bu, asenkron işlemin sonucunu temsil eden bir yapıdır.Task==void ile aynıdır async işlemlerle birlikte kulllanılır ve geri dönüş tipi yoktur.
        public async Task AddAsync(T entity)          
        {
            await Table.AddAsync(entity);
            //await, asenkron metotların işleyişini ve asenkron çağrı yapılan operasyonların sonuçlarını beklemek için kullanılan bir anahtar kelimedir.Bir metot içinde await kullanıldığında, o işlemin sonucunu beklemek için çalışma zamanında bir "askıya alma" işlemi gerçekleşir.Asenkron metotlar, uzun süren işlemleri sırayla beklemek yerine, işlem sırasında diğer işlemleri devam ettirir ve tamamlandığında sonucu döndürür. Böylece uygulamaların daha duyarlı ve verimli olmasına yardımcı olur.await, Task veya Task<T> döndüren asenkron operasyonların sonuçlarını beklemek için kullanılır. Bir asenkron metot, Task veya Task<T> tipinde bir değer döndürürse, bu dönüş değerini almak için await kullanılır.
           
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task <List<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null, params Expression<Func<T,object>>[] includeProporties)
        {
            IQueryable<T> query = Table;
            if(predicate!=null)
                query = query.Where(predicate);
            if(includeProporties.Any())
                foreach(var item in includeProporties)
                    query=query.Include(item);//ınclude bool değer döndüren bir metot

            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T, object>>[] includeProporties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);
           
            if (includeProporties.Any())
                foreach (var item in includeProporties)
                    query = query.Include(item);

            return await query.SingleAsync();
        }

        public async Task<T> GetByGuidAsync(Guid id)
        {
            return await Table.FindAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));

            return entity;
        }
    }
}
