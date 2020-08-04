using System;
using System.Collections.Generic;

namespace LatihanApi.Models
{
    public class Users
    {
        public int Id { get; set; }
        public DateTimeOffset Timestamps { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string RegisterIp { get; set; }
        public string ForgetSlug { get; set; }
        public string ActiveSlug { get; set; }
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
    }
}
