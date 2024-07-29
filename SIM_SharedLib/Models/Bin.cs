using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Models
{
	public class Bin
	{
		[Key]
		[Required]
		public string BinId { get; set; } = string.Empty;
	}
}
