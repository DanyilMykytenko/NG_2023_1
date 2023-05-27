namespace DAL.Entity
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
