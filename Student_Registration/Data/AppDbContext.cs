using Microsoft.EntityFrameworkCore;
using Student_Registration.Module;

namespace Student_Registration.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        { 
        }  

        DbSet<Student> Students { get; set; }
        
    }
}
