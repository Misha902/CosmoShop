using CosmoShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmoShop.Data
{
    public class SampleData
    {
        public static void Initialize(CosmoShopContext context)
        {
            var planets = new Category() { Name = "Planets"};
            var stars = new Category() { Name = "Stars" };

            context.SpaceObjects.AddRange(
                
                new SpaceObject
                    {
                        Name = "Mercury",
                        Description = "-mercury-",
                        ImgId = "pic1",
                        Price = 10000000000,
                        RotationPeriod = 58.646,
                        ObservedSatellites = 0,
                        Category = planets
                },
                new SpaceObject
                    {
                        Name = "Venus",
                        Description = "-venus-",
                        ImgId = "pic2",
                        Price = 20000000000,
                        RotationPeriod = 243.023,
                        ObservedSatellites = 0,
                        Category = planets
                },
                new SpaceObject
                    {
                        Name = "Earth",
                        Description = "We are here",
                        ImgId = "pic3",
                        Price = 30000000000,
                        RotationPeriod = 0.99726968,
                        ObservedSatellites = 1,
                        Category = planets
                },
                new SpaceObject
                    {
                        Name = "Mars",
                        Description = "-mars-",
                        ImgId = "pic4",
                        Price = 40000000000,
                        RotationPeriod = 1,
                        ObservedSatellites = 2,
                        Category = planets
                },
                new SpaceObject
                    {
                        Name = "Jupiter",
                        Description = "-jupiter-",
                        ImgId = "pic5",
                        Price = 50000000000,
                        RotationPeriod = 0.413541,
                        ObservedSatellites = 79,
                        Category = planets
                },
                new SpaceObject
                    {
                        Name = "Saturn",
                        Description = "-saturn-",
                        ImgId = "pic6",
                        Price = 60000000000,
                        RotationPeriod = 0.43,
                        ObservedSatellites = 82,
                        Category = planets
                },                                     
                new SpaceObject
                    {
                        Name = "Uran",
                        Description = "-uran-",
                        ImgId = "pic7",
                        Price = 70000000000,
                        RotationPeriod = 0.71833,
                        ObservedSatellites = 27,
                        Category = planets
                },
                new SpaceObject
                    {
                        Name = "Neptune",
                        Description = "blue",
                        ImgId = "pic8",
                        Price = 80000000000,
                        RotationPeriod = 0.6653,
                        ObservedSatellites = 14,
                        Category = planets
                    },
                new SpaceObject
                    {
                        Name = "Sun",
                        Description = "its very hot",
                        ImgId = "pic0",
                        Price = 100000000000000,
                        RotationPeriod = 0,
                        ObservedSatellites = 0,
                        Category = stars
                    }
            );
            context.Categories.AddRange(planets, stars);
            context.SaveChanges();
        }
    }
}
