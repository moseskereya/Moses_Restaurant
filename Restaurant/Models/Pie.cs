using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ThumNail { get; set; }
        public string LongDescription { get; set; }
        public Category Category { get; set; }

    }
}