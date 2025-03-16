namespace PasswordManager.Models
{
    internal class WorkflowCollection
    {
        internal SortableBindingList<BaseEntity>? BaseEntities { get; set; } = new();
    }
}