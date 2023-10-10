using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TowelMart.Models
{
    public class TowelSizeViewModel
    {
        // Genre in my project is  Size
        public List<Towel> Towels { get; set; }
        public SelectList Sizes { get; set; }
        public string towelSize { get; set; }
        public string SearchString { get; set; }
    }
}