using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace SIM_SharedLib.Models
{
	public class Address
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public uint AddressId { get; set; }

		[Required]
		public string Country { get; set; } = string.Empty;

		[Required]
		public string PostalCode { get; set; } = string.Empty;

		[Required]
		public string City { get; set; } = string.Empty;

		[Required]
		public string Street { get; set; } = string.Empty;

		[Required]
		public string BuildingNo { get; set; } = string.Empty;

		[Required]
		public string Unit { get; set; } = string.Empty;
	}
}
