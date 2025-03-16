namespace PasswordManager.Models
{
    internal class BaseEntity
    {
        internal Guid? Id { get; set; } = null!;
        internal string? ResourceName { get; set; } = null!;
        internal string? Login { get; set; } = null!;
        internal string? Password { get; set; } = null!;
        internal string? Link { get; set; } = null!;
        internal DateTime? CreatedDate { get; set; } = null!;
        internal DateTime? UpdatedDate { get; set; } = null!;
    }
}