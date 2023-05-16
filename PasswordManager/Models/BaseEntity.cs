namespace PasswordManager.Models
{
    internal abstract class BaseEntity
    {
        public Guid? Id { get; set; } = null!;
        public DateTime? CreatedDate { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; } = null!;
    }
}