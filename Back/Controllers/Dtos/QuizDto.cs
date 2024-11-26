using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ynov.QuizYnov.Controllers.Dtos
{
    public class QuizDto
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Difficulty { get; set; }

        public DateTime PublishedDate { get; set; }

        public Guid CategoryId { get; set; }
    }
}