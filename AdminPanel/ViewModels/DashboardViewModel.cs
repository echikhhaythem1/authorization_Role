using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.ViewModels
{
    public class DashboardViewModel
    {
        public int doctors_count { get; set; }
        public int roles_count { get; set; }
        public int admins_count { get; set; }

    }
}
