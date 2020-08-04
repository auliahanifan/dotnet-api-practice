using System;

namespace LatihanApi.Models
{
    public class PermissionRole
    {
        public virtual Roles Roles { get; set; }
        public virtual Permissions Permissions { get; set; }

    }
}
