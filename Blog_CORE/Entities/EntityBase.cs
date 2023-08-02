using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_CORE.Entities
{
    public abstract class EntityBase:IEntityBase
        //bütün classlarda tablolarda var olmasını istedğim prop ları buraya ekleyip buradan dahil edeceğim.Abstarct yapmamın sebebi ise örneğin 2 özelliğin image classında olmasını istiyorum fakat onların aynı zamnda category classında olmasını istemiyorum bu sebepten dolayı abstract yaptım.
    {
        public virtual Guid Id { get; set; }= Guid.NewGuid();//int seçtğimizde değeri 1 1 artıyor fakat guid seçtiğimizde öyle bir durum söz konusu değil
        public virtual string CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }= DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }   
        public virtual bool IsDeleted { get; set; }= false;

    }
}
