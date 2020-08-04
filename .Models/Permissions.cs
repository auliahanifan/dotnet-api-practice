using System;
using System.Collections.Generic;

namespace LatihanApi.Models
{
    public class Permissions
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }

    }
}
