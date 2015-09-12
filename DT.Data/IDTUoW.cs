using DT.Data.Repositories;
using DT.Model;

namespace DT.Data
{
    public interface IDTUoW
    {
        IRepository<Topic> TopicRepository { get; }
        IRepository<Question> QuestionRepository { get; }
        IRepository<Answer> AnswerRepository { get; }

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        void Commit();

        void Dispose();
    }
}