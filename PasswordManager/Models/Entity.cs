namespace PasswordManager.Models
{
    internal class Entity : BaseEntity
    {
        public string? ResourceName { get; set; } = null!;
        public string? Login { get; set; } = null!;
        public string? Password { get; set; } = null!;
        public string? Link { get; set; } = null!;
    }
}