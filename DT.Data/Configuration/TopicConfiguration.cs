using System.Data.Entity.ModelConfiguration;
using DT.Model;

namespace DT.Data.Configuration
{
    internal class TopicConfiguration
        : EntityTypeConfiguration<Topic>
    {
        public TopicConfiguration()
        {
            HasMany(t => t.Questions)
                .WithRequired(q => q.Topic)
                .HasForeignKey(q => q.TopicId);
        }
    }
}
