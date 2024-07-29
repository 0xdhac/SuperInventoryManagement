using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Interfaces
{
	public interface IRegistry<T>
	{
		void Register(T item);
		void Unregister(T item);

		List<T> Items { get; set; }
	}
}
