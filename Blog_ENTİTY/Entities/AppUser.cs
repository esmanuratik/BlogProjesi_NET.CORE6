using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ENTİTY.Entities
{
    public class AppUser:IdentityUser<Guid> //burası bizden bir key ister nasıl ki id ye birsey versmediğimizde string atıyorsa defalult deger olarak bundada guid vermeliyiz.
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
    }
}
