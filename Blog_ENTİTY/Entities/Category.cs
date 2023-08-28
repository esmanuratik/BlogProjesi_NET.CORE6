using Blog_CORE.Entities;
using Blog_ENTİTY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ENTİTY.Entities
{
    public class Category:EntityBase
    {
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
   
}

