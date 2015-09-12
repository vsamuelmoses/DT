using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DT.Model;

namespace DT.Data.DesignData
{
    public class DTDbInitialiser 
        : DropCreateDatabaseAlways<DTDbContext>
    {
        protected override void Seed(DTDbContext context)
        {
            var topics = GetTopics(context).ToList();
            AddTopics(context, topics);
        }

        private void AddQuestions(DTDbContext context, IEnumerable<Question> questions)
        {
            foreach (var question in questions)
                context.Questions.Add(question);

            context.SaveChanges();
        }

        private void AddTopics(DTDbContext context, IEnumerable<Topic> topics)
        {
            foreach (var topic in topics)
                context.Topics.Add(topic);

            context.SaveChanges();
        }


        private IEnumerable<Topic> GetTopics(DTDbContext context)
        {
            return new List<Topic>
            {
                GetTopic(context),
                GetTopic(context),
                GetTopic(context),
                GetTopic(context),
                GetTopic(context),
            };
        }

        private Topic GetTopic(DTDbContext context)
        {
            var t = new Topic();
            t.Questions = GetQuestions(context, t).ToList();
            t.Name = TopicNameGenerator();
            return t;
        }

        private static int _topicNumber = 1;
        private string TopicNameGenerator()
        {
            return "Topic " + _topicNumber++;
        }

        private IEnumerable<Question> GetQuestions(DTDbContext context, Topic topic)
        {
            return new List<Question>
            {
                GetQuestion(topic),
                GetQuestion(topic),
                GetQuestion(topic),
                GetQuestion(topic),
                GetQuestion(topic)
            };
        }

        private Question GetQuestion(Topic topic)
        {
            var q = new Question();
            q.Answers = GetAnswers(q);
            q.Topic = topic;
            q.Text = "This is a question";
            return q;
        }

        private ICollection<Answer> GetAnswers(Question question)
        {
            return new List<Answer>
            {
                GetAnswer(question),
                GetAnswer(question),
                GetAnswer(question, true),
                GetAnswer(question),
                GetAnswer(question)
            };
        }

        private Answer GetAnswer(Question question, bool isCorrect = false)
        {
            return new Answer()
            {
                Question = question,
                Text = "this is an answer to a question that I dont know",
                IsCorrect = isCorrect
            };
        }
    }
}
