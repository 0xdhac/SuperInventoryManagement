using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Plugin
{
	public static class Loader
	{
		public static List<IPlugin> LoadPlugins(string path)
		{
			List<IPlugin> plugins = [];

			foreach (var file in Directory.GetFiles(path, "*.dll"))
			{
				Assembly assembly = Assembly.LoadFrom(file);
				var types = assembly.GetTypes().Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsInterface);

				foreach (var type in types)
				{
					IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
					plugins.Add(plugin);
				}
			}

			return plugins;
		}
	}
}
