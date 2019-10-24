using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.ViewModels
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public string Password { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }


    }
}
