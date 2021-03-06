using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CP.API.Model
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}