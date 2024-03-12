using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCAppContext>>())) //Declarar las variables del using
            {
                //Ver todas las peliculas
                if (context.Movie.Any())
                {
                    return; //Listado de peliculas
                }
                context.Movie.AddRange(
                        new Movie
                        {
                            Title = "Tortugas Ninja",
                            ReleaseDate = DateTime.Parse("1980-2-3"),
                            Gender = "Accion",
                            Price = 7.99M,
                            Rating = "PG-13"
                        },
                         new Movie
                         {
                             Title = "Rey León",
                             ReleaseDate = DateTime.Parse("1986-12-16"),
                             Gender = "Infantil",
                             Price = 8.99M,
                             Rating = "PC-13"
                         },
                          new Movie
                          {
                              Title = "Toy Story 2",
                              ReleaseDate = DateTime.Parse("2003-10-23"),
                              Gender = "Infantil",
                              Price = 9.99M,
                              Rating = "R"

                          },
                           new Movie
                           {
                               Title = "Rapidos y Furiosos",
                               ReleaseDate = DateTime.Parse("1996-7-14"),
                               Gender = "Accion",
                               Price = 3.99M,
                               Rating = "R"
                           }
                        );
                    context.SaveChanges();
                }
        }
    }
}
