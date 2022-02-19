using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_commerce.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace e_commerce.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection") //webconfig 
        {
           
        }
    }
}