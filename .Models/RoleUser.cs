using System;

namespace LatihanApi.Models
{
    public class RoleUser
    {
        public virtual Roles Roles { get; set; }
        public virtual Users Users { get; set; }

    }
}
