using Microsoft.EntityFrameworkCore;
using WpfApp1.Model.DALandBLL.Persistance.DAO;

namespace WpfApp1.Model.DALandBLL.Persistance
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MO9QGPH;Database=net_project_db;User Id=sa;Password=root;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionScenarioDAO>().HasKey(i => new { i.id_Scenario, i.id_Action });
        }

        public DbSet<ActeurDAO> Acteur { get; set; }
        public DbSet<ActionDAO> Action { get; set; }
        public DbSet<ScenarioDAO> Scenario { get; set; }
        public DbSet<ActionScenarioDAO> ActionScenario { get; set; }
    }
}