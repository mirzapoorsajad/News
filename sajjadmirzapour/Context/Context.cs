using Microsoft.EntityFrameworkCore;
using sajjadmirzapour.Models;

namespace sajjadmirzapour
{
    public class Context : DbContext
    {




        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<News> News { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }





    }
}
