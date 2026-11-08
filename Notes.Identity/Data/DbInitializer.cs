namespace Notes.Identity.Data
{
    /// <summary>
    /// Инициализация базы данных
    /// </summary>
    public class DbInitializer
    {
        public static void Initialize(AuthDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}