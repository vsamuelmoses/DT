using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DT.Data.Configuration;
using DT.Data.DesignData;
using DT.Model;

namespace DT.Data
{
    public class DTDbContext : DbContext
    {
        private static DTDbContext instance;
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }

        static DTDbContext()
        {
            Database.SetInitializer(new DTDbInitialiser());
        }

        public DTDbContext()
        {
            Database.Initialize(false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Chinook Database does not pluralize table names
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new TopicConfiguration());
        }

      
    }
}
