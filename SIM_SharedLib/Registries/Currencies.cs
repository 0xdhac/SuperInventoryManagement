using SIM_SharedLib.Interfaces;
using SIM_SharedLib.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Registries
{
    /// <summary>
    /// A registry containing the types of currencies that the warehouse uses.
    /// </summary>
    public class CurrencyRegistry : IRegistry<Currency>
	{
		public List<Currency> Items { get; set; }

		public void Register(Currency item)
		{
			throw new NotImplementedException();
		}

		public void Unregister(Currency item)
		{
			throw new NotImplementedException();
		}
	}
}
