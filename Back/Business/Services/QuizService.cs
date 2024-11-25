using Ynov.QuizYnov.Business.Models;

namespace Ynov.QuizYnov.Business.Services
{
    public class QuizService : IQuizService
    {
        private List<Quiz> _quizList = new List<Quiz>()
        {
            new Quiz
            {
                Id = Guid.NewGuid(),
                Name = "Quiz 1",
                Description = "Description 1",
                Difficulty = 1,
                Category = new Category
                {
                    Id = Guid.NewGuid()
                }
            }
        };

        public IEnumerable<Quiz> GetAll()
        {
            return _quizList;
        }
    }
}