namespace PasswordManager.Models
{
    internal class BaseEntity
    {
        public Guid? Id { get; set; } = null!;
        public string? ResourceName { get; set; } = null!;
        public string? Login { get; set; } = null!;
        public string? Password { get; set; } = null!;
        public string? Link { get; set; } = null!;
        public DateTime? CreatedDate { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; } = null!;
    }
}