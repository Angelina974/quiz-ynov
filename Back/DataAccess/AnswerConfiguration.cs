using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ynov.QuizYnov.Business.Models;

public class AnswerConfiguration
    : IEntityTypeConfiguration<Response>
{
    public void Configure(EntityTypeBuilder<Response> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Text)
                .IsRequired();
                
        builder.Property(p => p.IsCorrect)
                .IsRequired();
    }
}