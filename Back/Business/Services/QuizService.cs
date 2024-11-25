using Ynov.QuizYnov.Business.Models;

namespace Ynov.QuizYnov.Business.Services
{
    public class QuizService : IQuizService
    {
        private List<Quiz> _quizList = new List<Quiz>()
        {
            new Quiz
            {
                // https://guidgenerator.com
                Id = new Guid("5f760b3b-1b7b-4b6b-8b1b-3b1b7b4b6b8b"),
                Name = "Dev fullstack M1",
                Description = "ASP .NET Core, Angular, etc.",
                Difficulty = 3,
                Category = new Category
                {
                    Id = new Guid("182b360a-ab56-47b9-b20c-5be9f626b9c8"),
                }
            }
        };

        public IEnumerable<Quiz> GetAll()
        {
            return _quizList;
        }

        public Quiz? Get(Guid id)
        {
            return _quizList.Find(q => q.Id == id);
        }

        public IEnumerable<Quiz> GetQuestionById(Guid questionId)
        {
            return _quizList.Find(q => q.QuizId == questionId);
        }
    }
}