using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TowelMart.Data;
using System;
using System.Linq;

namespace TowelMart.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TowelMartContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TowelMartContext>>()))
            {
                // Look for any movies.
                if (context.Towel.Any())
                {
                    return;   // DB has been seeded
                }

                context.Towel.AddRange(
    new Towel
    {
        Color = "White",
        ReleaseDate = DateTime.Parse("2023-01-15"),
        Size = "Medium",
        Price = 12.99M,
        StockQuantity = 100,
        Material = "Cotton",
        Brand = "TowelCo",
        ImageUrl = "/images/WhiteTowel.jpg"
    },

    new Towel
    {
        Color = "Blue",
        ReleaseDate = DateTime.Parse("2023-02-20"),
        Size = "Large",
        Price = 15.99M,
        StockQuantity = 50,
        Material = "Microfiber",
        Brand = "LuxTowels",
        ImageUrl = "/images/BlueTowel.jpg"
    },

    new Towel
    {
        Color = "Green",
        ReleaseDate = DateTime.Parse("2023-03-10"),
        Size = "Small",
        Price = 9.99M,
        StockQuantity = 75,
        Material = "Cotton",
        Brand = "GreenTowels",
        ImageUrl = "/images/GreenTowel.jpg"
    },

    new Towel
    {
        Color = "Red",
        ReleaseDate = DateTime.Parse("2023-02-28"),
        Size = "Medium",
        Price = 11.99M,
        StockQuantity = 60,
        Material = "Cotton",
        Brand = "RedTowels",
        ImageUrl = "/images/RedTowel.jpg"
    },

    new Towel
    {
        Color = "Yellow",
        ReleaseDate = DateTime.Parse("2023-04-05"),
        Size = "Large",
        Price = 14.99M,
        StockQuantity = 40,
        Material = "Microfiber",
        Brand = "YellowTowels",
        ImageUrl = "/images/YellowTowel.jpg"
    }
);

                context.SaveChanges();
            }
        }
    }
}
