using DEMO.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DEMO.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
