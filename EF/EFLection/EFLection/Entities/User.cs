namespace EFLection.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        public int? ManagerId { get; set; }

        public virtual Manager? Manager { get; set; }
        public virtual Account? Account { get; set; }
        public virtual ICollection<Team>? Teams { get; set; } = new HashSet<Team>();
    }
}
