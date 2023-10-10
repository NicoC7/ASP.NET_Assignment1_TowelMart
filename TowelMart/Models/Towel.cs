using System;
using System.ComponentModel.DataAnnotations;

namespace TowelMart.Models
{
    public class Towel
    {
        public int Id { get; set; }

        [Display(Name = "Towel Color")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public string Color { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Towel Size")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, ErrorMessage = "The {0} must be less than {1} characters.")]
        public string Size { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The {0} must be greater than 0.")]
        public decimal Price { get; set; }

        [Display(Name = "Stock Quantity")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "The {0} must be at least 1.")]
        public int StockQuantity { get; set; }

        [Display(Name = "Material")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, ErrorMessage = "The {0} must be less than {1} characters.")]
        public string Material { get; set; }

        [Display(Name = "Brand")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, ErrorMessage = "The {0} must be less than {1} characters.")]
        public string Brand { get; set; }

        [Display(Name = "Towel Image")]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string ImageUrl { get; set; }
    }
}
