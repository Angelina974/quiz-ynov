using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ynov.QuizYnov.Business.Models;

{
    public class UserConfiguration
        : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(120);

        builder.Property(p => p.Email)
               .IsRequired()
               .HasMaxLength(120);
    }
}
}