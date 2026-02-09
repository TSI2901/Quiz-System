using Microsoft.AspNetCore.Identity;
using System;

namespace QS.Data.Models
{
    // Fix: Inherit from IdentityUserRole<Guid> instead of IdentityRole<Guid>
    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}