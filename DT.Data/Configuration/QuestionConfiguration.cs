using System.Data.Entity.ModelConfiguration;
using DT.Model;

namespace DT.Data.Configuration
{
    public class QuestionConfiguration
        : EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            HasRequired(q => q.Topic)
                .WithMany(t => t.Questions)
                .HasForeignKey(q => q.TopicId);
        }
    }
}
