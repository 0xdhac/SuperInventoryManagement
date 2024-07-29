using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Plugin
{
	public interface IPlugin
	{
		string Name { get; }
		void Execute();
		void Stop();
	}
}