﻿using Microsoft.AspNetCore.Identity;

namespace XYB.Data.Entities
{
    /// <summary>
    /// To provide M:N relationship between AppUser and AppRole
    /// </summary>
    public class AppUserRole : IdentityUserRole<int>
    {
        public AppUser User { get; set; }

        public AppRole Role { get; set; }
    }
}
