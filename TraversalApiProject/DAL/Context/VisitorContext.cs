using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\hasan; database=TraversalApiProjectDB; integrated security=True;Connection Timeout=30;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
