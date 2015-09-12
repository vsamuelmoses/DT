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

        public static DTDbContext Instance
        {
            get
            {
                if(instance == null)
                    instance = new DTDbContext();

                return instance;
            }
            
        }

        public static DTDbContext Create()
        {
            var context = new DTDbContext();

            // Do NOT enable proxied entities, else serialization fails
            //context.Configuration.ProxyCreationEnabled = false;

            //// Load navigation properties explicitly (avoid serialization trouble)
            //context.Configuration.LazyLoadingEnabled = true;

            //// Because Web API will perform validation, we don't need/want EF to do so
            //context.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
            return context;
        }
    }
}
