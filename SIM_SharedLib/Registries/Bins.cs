using SIM_SharedLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Registries
{
	/// <summary>
	/// A bin is a location inside a warehouse or store that a product can be found.
	/// </summary>
	public class BinRegistry : IRegistry<string>
	{
		public List<string> Items { get; set; } = [];

		public void Register(string item)
		{
			throw new NotImplementedException();
		}

		public void Unregister(string item)
		{
			throw new NotImplementedException();
		}
	}
}
