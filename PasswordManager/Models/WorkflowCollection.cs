namespace PasswordManager.Models
{
    internal class WorkflowCollection
    {
        public SortableBindingList<BaseEntity>? BaseEntities { get; set; } = new();
    }
}