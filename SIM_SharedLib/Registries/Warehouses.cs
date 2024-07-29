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
	/// A registry containing all warehouses supported by the inventory management server
	/// </summary>
	public class WarehouseRegistry : IRegistry<Company>
	{
		public List<Company> Items { get; set; } = [];

		public void Register(Company item)
		{
			throw new NotImplementedException();
		}

		public void Unregister(Company item)
		{
			throw new NotImplementedException();
		}
	}
}
