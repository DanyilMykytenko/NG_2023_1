namespace EFLection.DbStartup
{
    public class DbInitializer
    {
        public static void Initialize(EFLectionContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
