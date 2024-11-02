using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using IdentityUser = Microsoft.AspNet.Identity.EntityFramework.IdentityUser;

namespace FastFood.Models
{
    public class ApplicationUser : IdentityUser
    {

        /// <summary>
        /// in this part we need to make class inherite directly from Idetity user to access authorization in the next time
        /// </summary>
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

    }
}
