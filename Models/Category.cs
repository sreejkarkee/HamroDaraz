using System.ComponentModel.DataAnnotations;

namespace HamroDaraz.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}