using System;

namespace Ynov.QuizYnov.Business.Models
{
    public class Response
    {
        public Guid Id { get; set; } 
        public string Text { get; set; } = ""; 
        public bool IsCorrect { get; set; } 
    }
}
