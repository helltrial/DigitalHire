namespace DigitalHire.Database
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public sealed class AppDbContext : DbContext
    {
        /// <summary>
        /// AppDbContext
        /// </summary>
        /// <param name="options">options</param>
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
