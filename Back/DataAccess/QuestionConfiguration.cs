using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ynov.QuizYnov.Business.Models;


public class QuestionConfiguration
    : IEntityTypeConfiguration<Question>
{

    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title)
                .HasMaxLength(120);

        builder.Property(p => p.Responses)
                .IsRequired();

        builder.Property(p => p.CorrectResponseId)
                .IsRequired();
    }


}
