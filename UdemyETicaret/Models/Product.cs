using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UdemyETicaret.Models;

namespace UdemyETicaret.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductTitle { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public bool ProductIsHome { get; set; }
        public bool ProductIsStock { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
