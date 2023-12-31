﻿using Blog_CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ENTİTY.Entities
{      //MAKALE   
    public class Article: EntityBase
    {
        public string Title { get; set; }   
        public string Content { get; set; }
        public int ViewCount { get; set; }   //Kaç defa görüntülendi

        //Diğer tablolarla bağlantı kurmak için
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid? ImageId { get; set; }   //ImageId nin null gelebilme ihtimali olduğu için.
        public Image Image { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
