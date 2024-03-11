using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamBlazorApp1.Models
{
	[Table(nameof(Product))]
	public class Product
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductID { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 6)]
		public string Name { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 3)]
		public string ProductNumber { get; set; }

		public string Color { get; set; }
		public DateTime? MFD { get; set; }

		[Required]
		public decimal StandardCost { get; set; }

		[Required]
		public decimal ListPrice { get; set; }

		[Required]
		public int Size { get; set; }

		[Required]
		public decimal Weight { get; set; }

		[ForeignKey(nameof(ProductCategory.ProductCategoryID))]
		public int ProductCategoryID { get; set; }

		public ProductCategory? ProductCategory { get; set; }

		public bool Available { get; set; }
	}
}
