using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamroDaraz.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Production / Manufacturer")]
        [StringLength(100)]
        public string Production { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 1000000.00)]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}