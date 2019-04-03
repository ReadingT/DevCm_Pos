// namespace cm_pos.Models
// {
//     public class Product
//     {
//         public int ID { get; set; }

//         public string NAME { get; set; }
//     }
// }

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cm_pos.Models
{
    public class Product
    {
        [Key]  //EF Core
        public int ProductID { get; set; }

       // [NotMapped]
       // public int Nattapong { get; set; }
        public string CodeName { get; set; }

        public string Name { get; set; }

        public string Detail { get; set; }

        public decimal Price { get; set; }

        public int CategoryID { get; set; } // Relation [Key]

        public string Image { get; set; }

        public string Timestamp { get; set; }

        [NotMapped]
        public int TotalStock { get; set; }

        [NotMapped]
        public bool NewProduct { get; set; }

        public virtual Category Categories { get; set; }

        public virtual ICollection<ProductSize> ProductsSizeList { get; set; }
    }
}