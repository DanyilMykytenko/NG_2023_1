namespace EFLection.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>(); 
    }
}
