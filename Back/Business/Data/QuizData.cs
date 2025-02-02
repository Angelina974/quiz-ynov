using Ynov.QuizYnov.Business.Models;
using System;
using System.Collections.Generic;

namespace Ynov.QuizYnov.Business
{
    public static class QuizData
    {
        public static List<Quiz> Quizzes = new List<Quiz>
        {
            new Quiz
            {
                Id = new Guid("5f760b3b-1b7b-4b6b-8b1b-3b1b7b4b6b8b"),
                Name = "Dev fullstack M1",
                Description = "ASP .NET Core, Angular, etc.",
                Difficulty = 3,
                Category = new Category { Name = "Informatique générale", Id = new Guid("182b360a-ab56-47b9-b20c-5be9f626b9c8") },
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Parmi les langages suivants, lesquels sont des langages web ?",
                        Responses = new List<Response>
                        {
                            new Response { Id = Guid.NewGuid(), Text = "HTML", IsCorrect = true },
                            new Response { Id = Guid.NewGuid(), Text = "C#", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "CSS", IsCorrect = true },
                            new Response { Id = Guid.NewGuid(), Text = "Python", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Qui est Brendan Eich ?",
                        Responses = new List<Response>
                        {
                            new Response { Id = Guid.NewGuid(), Text = "Créateur des concepts MVC dans la structuration des dossiers", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Le créateur de Javascript", IsCorrect = true },
                            new Response { Id = Guid.NewGuid(), Text = "Le co-fondateur avec Bill Gates, de microsoft", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Le créateur de PHP", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Parmis ses langages, lequel est un langage objet ?",
                        Responses = new List<Response>
                        {
                            new Response { Id = Guid.NewGuid(), Text = "Vue", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Swift", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Kotlin", IsCorrect = true },
                            new Response { Id = Guid.NewGuid(), Text = "Php", IsCorrect = false }
                        }
                    },
                     new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "URI signifie...",
                        Responses = new List<Response>
                        {
                            new Response { Id = Guid.NewGuid(), Text = "Universal Rated Identification", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Usual Reactive Idea", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Universal Ressources Identification", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Uniform Resource Identifier", IsCorrect = true }
                        }
                    },
                },
                PublishedDate = new DateTime(2021, 10, 1, 12, 00, 00),
            },

            //Un autre quiz 
            new Quiz
            {
                Id = new Guid("fd39a452-e7de-494e-8427-4632950ff411"),
                Name = "Cybersécurité générale",
                Description = "Cybersécurité...",
                Difficulty = 2,
                Category = new Category { Name = "Informatique générale", Id = new Guid("182b360a-ab56-47b9-b20c-5be9f626b9c8") },
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Comment éviter une injection SQL ?",
                        Responses = new List<Response>
                        {
                            new Response { Id = Guid.NewGuid(), Text = "Ne pas autoriser les requête SQL", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Mettre à jour le site régulièrement", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Vérifier tout les input et front et en back", IsCorrect = true },
                            new Response { Id = Guid.NewGuid(), Text = "Rajouter des token jwt", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Title = "Parmis ses attaques, laquelle est la plus courante ?",
                        Responses = new List<Response>
                        {
                            new Response { Id = Guid.NewGuid(), Text = "Les attaques DDOS", IsCorrect = true },
                            new Response { Id = Guid.NewGuid(), Text = "Les injections SQL", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Les failles XSS", IsCorrect = false },
                            new Response { Id = Guid.NewGuid(), Text = "Les attaques man-in-the-middle (MitM)", IsCorrect = false }
                        }
                    },
                    
                },
                PublishedDate = new DateTime(2021, 10, 1, 12, 00, 00),
            },
            
            };

            //La liste des quiz qu'on relie à nos quiz au dessus avec la fonction getCategories et on ressort tout les quiz avec GetQuizzesByCategories
            public static IEnumerable<Category> Categories = new[] {
                new Category {
                    Id = new Guid("182b360a-ab56-47b9-b20c-5be9f626b9c8"),
                    Name = "Informatique générale",
                }


            };
    }
}
