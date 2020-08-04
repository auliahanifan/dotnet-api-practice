namespace LatihanApi.Dtos.User
{
    public class GetUserDto
    {
        public int Id { get; set; }
        // public DateTimeOffset? Timestamps { get; set; }
        public string Username { get; set; } = "aul";
        public string Email { get; set; } = "aul@aul.com";
    }
}