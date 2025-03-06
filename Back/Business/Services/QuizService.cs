using Ynov.QuizYnov.Business.Models;
using System;
using System.Collections.Generic;

namespace Ynov.QuizYnov.Business.Services
{
    public class QuizService : IQuizService
    {
        public IEnumerable<Quiz> GetAll()
        {
            return QuizData.Quizzes;
        }

        public Quiz? Get(Guid id)
        {
            return QuizData.Quizzes.FirstOrDefault(q => q.Id == id);
        }

        public IEnumerable<Question> GetQuestions(Guid quizId)
        {
            var quiz = QuizData.Quizzes.First(x => x.Id == quizId);
            return quiz.Questions;
        }

        public IEnumerable<Category> GetCategories(Guid categoryId)
        {
            var quizzesInCategory = QuizData.Quizzes.Where(q => q.Category == categoryId);
            //récupère les quiz dans la data, et vérifie que les catégories dans le quiz sont les mêmes que ceux qu'on demande

            if (quizzesInCategory != null) {
                return new List<Quiz> {
                }

            } else {
                return Enumerable.Empty<Quiz>();
            }

        }

        internal static object GetQuizWithQuestions(object quizId)
        {
            throw new NotImplementedException();
        }
    }
}
