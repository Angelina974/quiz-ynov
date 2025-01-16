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

         public IEnumerable<Category> GetCategories(Guid categoryId) {
            return QuizData.Categories.Where(c => c.Id == categoryId);
         }

        public IEnumerable<Quiz> GetQuizzesByCategories(Guid categoryId, Guid quizId) {
            
        }


    }
}
