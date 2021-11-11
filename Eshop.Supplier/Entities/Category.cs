using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eshop.Supplier.Entities
{
    [Table("Categroy")]
    public class Category
    {
       [Key] //apply pk
        public int CategroyId { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string CategroyName { get; set; }
    }
}
