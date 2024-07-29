using SIM_SharedLib.Interfaces;
using SIM_SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Registries
{
	/// <summary>
	/// A registry of all valid product categories for the current inventory
	/// </summary>
	public class CategoryRegistry : IRegistry<Category>
	{
		public List<Category> Items { get; set; } = [];

		public void Register(Category item)
		{
			throw new NotImplementedException();
		}

		public void Unregister(Category item)
		{
			throw new NotImplementedException();
		}
	}
}
