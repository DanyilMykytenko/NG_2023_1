namespace DAL.Entity
{
    public class Account : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
