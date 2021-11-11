using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eshop.Supplier.Entities
{
    [Table("Item")]
    public class Item
    {
        [Key]
        [StringLength(5)]
        [Column(TypeName ="Char")]
        public string ItemId { get; set; }
        [StringLength(20)]
        [Required] //set as not null
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int? Stock { get; set; } //set as null

        [ForeignKey("Category")]
        public int CategroyId { get; set; }

        public Category Category { get; set; } //Navigation property
    }
}
