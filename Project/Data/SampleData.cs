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
                        Name = "Earth",
                        Description = "We are here",
                        ImgId = "CO-2",
                        Price = 300000000000,
                        RotationPeriod = 0.99726968,
                        ObservedSatellites = 1
                    },
                    new SpaceObject
                    {
                        Name = "Sun",
                        Description = "its very hot",
                        ImgId = "CO-1",
                        Price = 900000000000000,
                        RotationPeriod = 0,
                        ObservedSatellites = 0
                    },
                    new SpaceObject
                    {
                        Name = "Neptune",
                        Description = "blue",
                        ImgId = "CO-3",
                        Price = 800000000000,
                        RotationPeriod = 0.6653,
                        ObservedSatellites = 14
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
