namespace EFLection.Entities
{
    public class Manager : BaseEntity
    {
        public string FullName { get; set; }


        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
