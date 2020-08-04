using System;

namespace LatihanApi.Models
{
    public class LoginAttempts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string LoginIp { get; set; }
        public DateTimeOffset Timestamps { get; set; }

    }
}
