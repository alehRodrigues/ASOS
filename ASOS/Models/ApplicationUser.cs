using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
