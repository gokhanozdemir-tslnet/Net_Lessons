namespace Lesson004_JWTToken.Entities
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public string? PersonName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
    }
}