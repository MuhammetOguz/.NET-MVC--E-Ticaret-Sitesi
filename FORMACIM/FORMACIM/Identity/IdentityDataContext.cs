using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FORMACIM.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext():base("Server=DESKTOP-9ALDN9L;Database=FORMACIM;Integrated Security=true")
        {
            
        }

        public System.Data.Entity.DbSet<FORMACIM.Models.RegisterModel> RegisterModels { get; set; }
    }
}