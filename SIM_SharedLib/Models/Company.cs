using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using SIM_SharedLib.Structures;
using SIM_SharedLib.Validators;

namespace SIM_SharedLib.Models
{
	public class Company
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public uint CompanyId { get; set; }

		[Required]
		[PhoneNumberValidator]
		public string PhoneNumber { get; set; } = string.Empty;

		[Required]
		public string Name { get; set; } = string.Empty;

		public string Website { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public Address? Address { get; set; }
	}
}
