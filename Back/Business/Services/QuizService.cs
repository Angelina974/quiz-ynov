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

        public IEnumerable<Category> GetCategories(Guid categoryId, Guid quizzId)
        {
            var quiz = QuizData.Quizzes.FirstOrDefault(q => q.Id == quizzId);
            
            if (quiz != null && quiz.Category.Id == categoryId)
            {
                return new List<Category> { quiz.Category }; 
            }
        
            return Enumerable.Empty<Category>(); 
        }




    }
}
