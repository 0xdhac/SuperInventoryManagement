using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Models
{
	public class Description
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public uint DescriptionId { get; set; }

		[ForeignKey("Product")]
		public uint ProductId { get; set; }

		[Required]
		public string Summary { get; set; } = string.Empty;

		public ICollection<Feature> Features { get; set; } = [];
		public ICollection<Specification> Specifications { get; set; } = [];
	}

	public class Feature
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public uint FeatureId { get; set; }

		[Required]
		[ForeignKey("Description")]
		public uint DescriptionId { get; set; }

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public string Description { get; set; } = string.Empty;
	}

	public class Specification
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public uint SpecificationId { get; set; }

		[Required]
		[ForeignKey("Description")]
		public uint DescriptionId { get; set; }

		[Required]
		public string Key { get; set; } = string.Empty;

		[Required]
		public string Value { get; set; } = string.Empty;
	}
}
