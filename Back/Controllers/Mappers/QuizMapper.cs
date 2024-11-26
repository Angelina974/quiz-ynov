using Ynov.QuizYnov.Business.Models;
using Ynov.QuizYnov.Controllers.Dtos;

namespace Ynov.QuizYnov.Controllers.Mappers
{
    public class QuizMapper
    {
        public QuizDto ToDto(Quiz quiz)
        {
            return new QuizDto
            {
                Id = quiz.Id,
                Name = quiz.Name,
                Description = quiz.Description,
                Difficulty = quiz.Difficulty,
                CategoryId = quiz.Category.Id,
                PublishedDate = quiz.PublishedDate,
            }; 
        }
    }
}