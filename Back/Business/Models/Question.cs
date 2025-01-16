using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ynov.QuizYnov.Business.Models
{
    public class Question
    {

        public Guid Id { get; set; }

        public string? Title { get; set; }

        public IEnumerable<Response> Responses {get; set;} = new List<Response>();

        
        
    }
}