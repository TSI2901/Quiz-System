using Microsoft.AspNetCore.Identity;
using QS.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QS.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            UsersRoles = new HashSet<ApplicationUserRole>();
        }

        //[MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        //[MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public ApprovalStatus ApprovalStatus { get; set; }

        public virtual ICollection<ApplicationUserRole> UsersRoles { get; set; }
    }
}
