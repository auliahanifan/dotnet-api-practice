using System;
using System.Collections.Generic;

namespace LatihanApi.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }

    }
}
