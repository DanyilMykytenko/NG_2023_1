namespace EFLection.Entities
{
    public class Account : BaseEntity 
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual User User { get; set; }
    }
}
