using Ynov.QuizYnov.Business.Models;

namespace Ynov.QuizYnov.Business
{
    public interface IQuizService
    {
        IEnumerable<Quiz> GetAll();
        
        Quiz? Get(Guid id);

        IEnumerable<Question>? GetQuestions(Guid QuestionId);

        IEnumerable<Category>? GetCategories(Guid CategoryId, Guid quizzId);
    }
}