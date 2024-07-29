using Microsoft.EntityFrameworkCore;
using SIM_SharedLib.Structures;
using SIM_SharedLib.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Models
{
    [Index("Identifier", IsUnique = true)]
	public class Product
    {
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductId { get; set; }

		[Required]
        public string Identifier { get; set; } = string.Empty;

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		[ForeignKey("Description")]
		public uint DescriptionId { get; set; }

		public Description? Description { get; set; }

		[Required]
		public string Category { get; set; } = string.Empty;

		[Required]
		public uint ManufactererId { get; set; }

		[ForeignKey("ManufactererId")]
		public Company Manufacterer { get; set; }

		[Required]
		[USDPriceValidator]
		public double PricePerUnit { get; set; }

		[Required]
		[USDPriceValidator]
		public double CostPerUnit { get; set; }

		
		[Required]
		public uint SupplierId { get; set; }

		[ForeignKey("SupplierId")]
		public Company Supplier { get; set; }
		

		[Required]
		public int QuantityAvailable { get; set; }

		[Required]
		public int ReorderQuantity { get; set; }

		[Required]
		[ForeignKey("Bin")]
		public string BinId { get; set; }

		public Bin Bin { get; set; }
		
    }
}
