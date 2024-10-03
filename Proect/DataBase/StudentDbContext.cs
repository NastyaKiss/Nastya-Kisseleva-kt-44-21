using Microsoft.EntityFrameworkCore;
namespace KiselevaAnastasiaKt_44_21.DataBase
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<
            StudentDbContext> options) : base(options) { 
        }
    }
}
