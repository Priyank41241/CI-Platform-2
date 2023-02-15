using Microsoft.EntityFrameworkCore;

namespace CI_Platform.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            { }
    }
}
 