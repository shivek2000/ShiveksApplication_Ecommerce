using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShiveksApplication_Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiveksApplication_Ecommerce.Data
{
    public class AppDbIntializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using var servicescope = applicationBuilder.ApplicationServices.CreateScope();

            var context = servicescope.ServiceProvider.GetService<AppDbContext>();

            //cinema
            if (!context.Cinemas.Any())
            {
                context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cimema 1",
                            Logo ="https://i.pinimg.com/474x/59/95/18/5995186a3da28eef8906f5d3878c76c2.jpg",
                            Description ="Black man cinema"

                        },

                            new Cinema()
                            {
                            Name="Cimema 2",
                            Logo ="data:image/jpeg;base64,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",
                            Description ="Shrek man cinema"
                            },
                              new Cinema()
                            {
                            Name="Cimema 3",
                            Logo="data:image/jpeg;base64,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",
                            Description ="Cat man cinema"
                            },

                    });
            }
            //movies
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new List<Movie>()
                {
                    new Movie()
                    {
                        Name = "Shrek",
                        Description = "shrek",
                        Price = 1,
                        ImageUrl = "https://i.seadn.io/gae/2hDpuTi-0AMKvoZJGd-yKWvK4tKdQr_kLIpB_qSeMau2TNGCNidAosMEvrEXFO9G6tmlFlPQplpwiqirgrIPWnCKMvElaYgI-HiVvXc?auto=format&dpr=1&w=1000",
                        startDate = DateTime.Now,
                        endDate = DateTime.Now.AddDays(10),
                        cinema = new Cinema()
                        {
                            Id = 2
                        },
                        producer = new Producer()
                        {
                            ProducerId = 1
                        }


                    },
                     new Movie()
                    {
                        Name = "Hood Fight",
                        Description = "Glock stuff",
                        Price = 100,
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRnhtqcvks8tXViJdngAFjO-5OtgmcTL6-Skg&usqp=CAU",
                        startDate = DateTime.Now,
                        endDate = DateTime.Now.AddDays(10),
                        cinema = new Cinema()
                        {
                            Id = 1
                        },
                        producer = new Producer()
                        {
                            ProducerId = 2
                        }


                    },
                      new Movie()
                    {
                        Name = "Cat Women",
                        Description = "Cats",
                        Price = 100,
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRnhtqcvks8tXViJdngAFjO-5OtgmcTL6-Skg&usqp=CAU",
                        startDate = DateTime.Now,
                        endDate = DateTime.Now.AddDays(10),
                        cinema = new Cinema()
                        {
                            Id = 3
                        },
                        producer = new Producer()
                        {
                            ProducerId = 3
                        }


                    }
                });
                //producer
                if (!context.Producer.Any())
                {
                    context.Producer.AddRange(new List<Producer>(){
                    new Producer()
                    {
                        Name = "Shrek",
                        profilePictureURL = "https://i.seadn.io/gae/2hDpuTi-0AMKvoZJGd-yKWvK4tKdQr_kLIpB_qSeMau2TNGCNidAosMEvrEXFO9G6tmlFlPQplpwiqirgrIPWnCKMvElaYgI-HiVvXc?auto=format&dpr=1&w=1000",
                        Biography = "Swamp life good"

                    },
                        new Producer()
                    {
                        Name = "Black man",
                        profilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSx9qfD86bVw3jofn3J5Tf21QhDuqrDSdVPHw&usqp=CAU",
                        Biography = "Chicken"

                    },

                               new Producer()
                    {
                        Name = "Cat man",
                        profilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTsiVEqbFR56Rn44iiP8pw9xosCcLImLaMYKXU_a90ynqpL55qfLefUuEhYQjLF3kJMcR8&usqp=CAU",
                        Biography = "Cat"

                    }

                });


                    //actor movies
                    if (!context.Actor_Movie.Any())
                    {

                    }
                    //actors
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Name="Tyrone",
                            profilePictureURL ="https://www.usatoday.com/gcdn/-mm-/2f927176fc1e8e0a31a6f6117d6cbdf9b1e47589/c=348-61-1367-637/local/-/media/2015/09/18/USATODAY/USATODAY/635781741516984466-Luckie.jpg?width=1200&disable=upscale&format=pjpg&auto=webp",
                            Biography ="Loves chicken"

                        },

                        new Actor()
                        {
                            Name="Devantai",
                            profilePictureURL ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQ-EJUvTxkBlrP2Lp0tvLcKJGtTXypawi_-IEbZT2WTuKbd8Aik6DKyl_87g18Opd17to&usqp=CAU",
                            Biography ="Loves chicken"

                        },

                         new Actor()
                        {
                            Name="Sha kneek O steal",
                            profilePictureURL ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCXTxrg3bhGtuYUOoDlZE30Ryaxa5ujiX7VoU95iSeShffVgrsidjhNZn6W7PcIonTCmw&usqp=CAU",
                            Biography ="Loves chicken"

                        },


                    });

                    }
                }
            }

        }
    }
}