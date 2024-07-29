using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIM_SharedLib.Models
{
	public class Warehouse
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public uint WarehouseId { get; set; }

		[Required]
		public string Name { get; set; }
	}
}
