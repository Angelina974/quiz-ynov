using Ynov.QuizYnov.Controllers.Mappers;
using Ynov.QuizYnov.Business.Services;
using Ynov.QuizYnov.Business.Models;
using Ynov.QuizYnov.Business;
using Microsoft.EntityFrameworkCore;


namespace Ynov.QuizYnov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IQuizService, QuizService>();
            builder.Services.AddScoped<QuizMapper>();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string not found");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                // Génère la BDD si nécessaire 
                var serviceScope = app.Services.CreateScope();
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context?.Database.EnsureCreated();
            }

            app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}