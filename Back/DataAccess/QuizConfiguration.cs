using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ynov.QuizYnov.Business.Models;

{
    public class QuizConfiguration
    : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(120);

        builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(120);

        builder.Property(p => p.Difficulty)
                .IsRequired();

        builder.Property(p => p.PublishedDate)
                .IsRequired();

        builder.Property(p => p.Category)
                .IsRequired();

        builder.HasMany(p => p.Questions)
                .WithOne(p => p.Quiz)
                .HasForeignKey(p => p.QuizId)
                .OnDelete(DeleteBehavior.Cascade);

    }

}
}