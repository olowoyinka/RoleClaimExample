﻿using System.Collections.Generic;

namespace RoleClaimExample.Models
{
    public class PermissionViewModel
    {
        public string RoleId { get; set; }

        public IList<RoleClaimsViewModel> RoleClaims { get; set; }
    }
}