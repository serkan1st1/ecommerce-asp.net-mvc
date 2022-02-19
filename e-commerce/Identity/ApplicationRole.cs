using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace e_commerce.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }

        public ApplicationRole() //constructor
        {

        }

        public ApplicationRole(string rolename, string description)
        {
            this.Description = description;
        }
    }
}