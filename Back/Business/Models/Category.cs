using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ynov.QuizYnov.Business.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
        
    }
}