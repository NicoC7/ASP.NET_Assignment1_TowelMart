using System;
using System.ComponentModel.DataAnnotations;

namespace TowelMart.Models
{
    public class Towel
    {
        public int Id { get; set; }
        public string Color { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Material { get; set; }

        public string Brand { get; set; }

        public string ImageUrl { get; set; }
    }
}