using Microsoft.EntityFrameworkCore;



namespace AvailityAngular.Model
{
    public class AppDBContext:DbContext
    {
        public AppDBContext( DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
