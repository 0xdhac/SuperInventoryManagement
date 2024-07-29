using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Models
{
	public class Category
	{
		string Value { get; set; }

		public Category(string value)
		{
			Value = value; 
		}

		public static implicit operator Category(string value)
		{
			return new Category(value);
		}

		public override string ToString()
		{
			return Value;
		}
	}
}
