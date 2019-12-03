using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
           
                WdaContext context = app.ApplicationServices
                .GetRequiredService<WdaContext>();
                //context.Database.Migrate();

                //modelBuilder.Entity<RoomType>().HasData(new RoomType
                //{
                //    RoomType1 = "Single",
                //    Id = 1
                //});
                //modelBuilder.Entity<Room>().HasData(
                //    new Room
                //    {
                //        RoomId = 1,
                //        Name = "Flower",
                //        City = "Dnipro",
                //        Area = "Dnipropetrovska",
                //        Photo = "Photo",
                //        CountOfGuests = 1,
                //        LatLocation = "Uk",
                //        LngLocation = "Ukraine",
                //        LongDescription = "Cool room to chill in alone",
                //        ShortDescription = "Cool room",
                //        PetFriendly = 1,
                //        Wifi = 1,
                //        Parking = 1,
                //        Price = 540,
                //        RoomTypeId = 1,
                //        Location = "Ukraine"
                //    });

                if (!context.Room.Any())
                {
                
                    context.Room.AddRange(
                        new Room
                        {
                            RoomId = 1,
                            Name = "Flower",
                            City = "Dnipro",
                            Area = "Dnipropetrovska",
                            Photo = "room-1.jpg",
                            CountOfGuests = 1,
                            LatLocation = "Uk",
                            LngLocation = "Ukraine",
                            LongDescription = "Cool room to chill in alone",
                            ShortDescription = "Cool room",
                            PetFriendly = 1,
                            Wifi = 1,
                            Parking = 1,
                            Price = 540,
                            RoomTypeId = 4,
                            Location = "Ukraine",
                            RoomType = new RoomType
                            {
                                RoomType1 = "Single",
                                Id = 4
                            }
                        },
                          new Room
                          {
                              RoomId = 3,
                              Name = "Zoloti Vorota",
                              City = "Kyiv",
                              Area = "Kyivska",
                              Photo = "room-2.jpg",
                              CountOfGuests = 2,
                              LatLocation = "Uk",
                              LngLocation = "Ukraine",
                              LongDescription = "Cool room for 2 people",
                              ShortDescription = "Cool room",
                              PetFriendly = 1,
                              Wifi = 1,
                              Parking = 1,
                              Price = 640,
                              RoomTypeId = 1,
                              Location = "Ukraine",
                              RoomType = new RoomType
                              {
                                  RoomType1 = "For two",
                                  Id = 3
                              }

                          }
                            );

                    context.SaveChanges();
                }
                if (!context.RoomType.Any())
                {
                    context.RoomType.AddRange(
                          new RoomType
                          {
                              RoomType1 = "Single",
                              Id = 1
                          },
                           new RoomType
                           {
                               RoomType1 = "Single",
                               Id = 2
                           });
                }
            
        }
    }
}
