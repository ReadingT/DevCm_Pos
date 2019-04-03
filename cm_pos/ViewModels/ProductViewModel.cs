using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using cm_pos.Models;
using Microsoft.AspNetCore.Mvc;

namespace cm_pos.ViewModels
{
    public class ProductViewModel
    {
        [HiddenInput]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product ID", Prompt = "กรอกฉันหน่อยสิ")]
        [MinLength(5)]
        [MaxLength(10)]
        public string CodeName { get; set; }

        [Required, MinLength(1), MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "หิวข้าวโว๊ยยยยยยย")]
        [MaxLength(1000)]
        public string Detail { get; set; }

        [Required]
        [Range(100, 500000, ErrorMessage = "Range of price is 100 - 500,000")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [HiddenInput]
        public string Image { get; set; }

        public string Timestamp { get; set; }

        [Display(Name = "Category")]
        public Category Categories { get; set; }

        public ICollection<ProductSize> Products_size { get; set; }
    }
}