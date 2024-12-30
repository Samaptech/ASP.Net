using ASP.Net.Models;
using Microsoft.EntityFrameworkCore;


namespace ASP.Net.SqlDb
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext>options):base(options)
        {
                   
        }

        public DbSet<Members> MemberShip {  get; set; }

        public DbSet<MemberShip> MemberShip_PREMIEM{ get; set;}
    }
}
