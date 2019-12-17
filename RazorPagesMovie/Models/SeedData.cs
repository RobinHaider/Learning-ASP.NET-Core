using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Once Upon a Time in Hollywood",
                        ReleaseDate = DateTime.Parse("2019-2-12"),
                        Genre = "Drama Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Doctor Sleep ",
                        ReleaseDate = DateTime.Parse("2019-3-13"),
                        Genre = "Horror",
                        Price = 8.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "6 Undergrounds",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Kabir Singh",
                        ReleaseDate = DateTime.Parse("2019-3-23"),
                        Genre = "Romantic Drama",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Frozen 2",
                        ReleaseDate = DateTime.Parse("2019-4-15"),
                        Genre = "Animation",
                        Price = 3.99M,
                        Rating = "PG-13"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}