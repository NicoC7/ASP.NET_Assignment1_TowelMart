﻿using Microsoft.EntityFrameworkCore;
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
        ImageUrl = "/images/WhiteTowel.jpg",
        CustomerReviewRating = 5
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
        ImageUrl = "/images/BlueTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "Green",
        ReleaseDate = DateTime.Parse("2023-03-10"),
        Size = "Small",
        Price = 9.99M,
        StockQuantity = 75,
        Material = "Cotton",
        Brand = "TowelCo",
        ImageUrl = "/images/GreenTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "Red",
        ReleaseDate = DateTime.Parse("2023-02-28"),
        Size = "Medium",
        Price = 11.99M,
        StockQuantity = 60,
        Material = "Cotton",
        Brand = "LuxTowels",
        ImageUrl = "/images/RedTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "Yellow",
        ReleaseDate = DateTime.Parse("2023-04-05"),
        Size = "Large",
        Price = 14.99M,
        StockQuantity = 40,
        Material = "Microfiber",
        Brand = "TowelCo",
        ImageUrl = "/images/YellowTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "White",
        ReleaseDate = DateTime.Parse("2023-01-15"),
        Size = "Small",
        Price = 12.99M,
        StockQuantity = 90,
        Material = "Cotton",
        Brand = "TowelCo",
        ImageUrl = "/images/WhiteTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "White",
        ReleaseDate = DateTime.Parse("2023-01-15"),
        Size = "Medium",
        Price = 11.99M,
        StockQuantity = 100,
        Material = "Microfiber",
        Brand = "LuxTowels",
        ImageUrl = "/images/WhiteTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "Red",
        ReleaseDate = DateTime.Parse("2023-01-15"),
        Size = "Large",
        Price = 14.99M,
        StockQuantity = 35,
        Material = "Microfiber",
        Brand = "TowelCo",
        ImageUrl = "/images/WhiteTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "Blue",
        ReleaseDate = DateTime.Parse("2023-01-15"),
        Size = "Small",
        Price = 16.99M,
        StockQuantity = 25,
        Material = "Cotton",
        Brand = "LuxTowels",
        ImageUrl = "/images/WhiteTowel.jpg",
        CustomerReviewRating = 5
    },

    new Towel
    {
        Color = "Green",
        ReleaseDate = DateTime.Parse("2023-01-15"),
        Size = "Medium",
        Price = 17.99M,
        StockQuantity = 10,
        Material = "Microfiber",
        Brand = "TowelCo",
        ImageUrl = "/images/WhiteTowel.jpg",
        CustomerReviewRating = 5
    }
);

                context.SaveChanges();
            }
        }
    }
}
