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
            if (!context.SpaceObjects.Any())
            {
                context.SpaceObjects.AddRange(
                    
                    new SpaceObject
                    {
                        Name = "Mercury",
                        Description = "-mercury-",
                        ImgId = "CO-1",
                        Price = 100000000000,
                        RotationPeriod = 58.646,
                        ObservedSatellites = 0
                    },
                    new SpaceObject
                    {
                        Name = "Venus",
                        Description = "-venus-",
                        ImgId = "CO-2",
                        Price = 20000000000,
                        RotationPeriod = 243.023,
                        ObservedSatellites = 0
                    },
                    new SpaceObject
                    {
                        Name = "Earth",
                        Description = "We are here",
                        ImgId = "CO-3",
                        Price = 30000000000,
                        RotationPeriod = 0.99726968,
                        ObservedSatellites = 1
                    },
                    new SpaceObject
                    {
                        Name = "Mars",
                        Description = "-mars-",
                        ImgId = "CO-4",
                        Price = 40000000000,
                        RotationPeriod = 1,
                        ObservedSatellites = 2
                    },
                    new SpaceObject
                    {
                        Name = "Jupiter",
                        Description = "-jupiter-",
                        ImgId = "CO-5",
                        Price = 50000000000,
                        RotationPeriod = 0.413541,
                        ObservedSatellites = 79
                    },
                    new SpaceObject
                    {
                        Name = "Saturn",
                        Description = "-saturn-",
                        ImgId = "CO-6",
                        Price = 60000000000,
                        RotationPeriod = 0.43,
                        ObservedSatellites = 82
                    },                                     
                    new SpaceObject
                    {
                        Name = "Uran",
                        Description = "-uran-",
                        ImgId = "CO-7",
                        Price = 70000000000,
                        RotationPeriod = 0.71833,
                        ObservedSatellites = 27
                    },
                    new SpaceObject
                    {
                        Name = "Neptune",
                        Description = "blue",
                        ImgId = "CO-8",
                        Price = 80000000000,
                        RotationPeriod = 0.6653,
                        ObservedSatellites = 14
                    },
                    new SpaceObject
                    {
                        Name = "Sun",
                        Description = "its very hot",
                        ImgId = "CO-0",
                        Price = 100000000000000,
                        RotationPeriod = 0,
                        ObservedSatellites = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
