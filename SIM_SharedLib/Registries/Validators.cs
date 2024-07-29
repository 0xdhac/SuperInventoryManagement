using SIM_SharedLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Registries
{
	/// <summary>
	/// A registry containing 
	/// </summary>
	public class ValidatorRegistry : IRegistry<IValidator>
	{
		public List<IValidator> Items { get; set; } = [];

		public void Register(IValidator item)
		{
			throw new NotImplementedException();
		}

		public void Unregister(IValidator item)
		{
			throw new NotImplementedException();
		}
	}
}
