namespace Ynov.QuizYnov.Business.Models

{
    public class Quiz
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Difficulty { get; set; }

        public DateTime PublishedDate { get ; set; }

        public Category Category { get; set; }

        public IEnumerable<Question> Questions { get; set; }

    }
        
}

