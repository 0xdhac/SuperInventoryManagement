using Microsoft.EntityFrameworkCore;
using SIM_SharedLib.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Models
{
    public class Cart
    {
		[Key]
		public uint Id { get; set; }

		[NotMapped]
        public ICollection<Product> Products { get; set; } = [];

		[NotMapped]
        public ICollection<IDiscount> Discounts { get; set; } = [];
    }
}
