using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QS.Data.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
        {
            UsersRoles = new List<ApplicationUserRole>();
        }
        public virtual ICollection<ApplicationUserRole> UsersRoles { get; set; }
    }
}
