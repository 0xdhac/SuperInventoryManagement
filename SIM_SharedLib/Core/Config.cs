using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Core
{
	public class Config
	{
		Dictionary<string, dynamic> Settings { get; set; } = [];

		public void Set(string key, dynamic value)
		{
			if(Settings.TryGetValue(key, out _))
			{
				Settings[key] = value;
			}
			else
			{
				Settings.Add(key, value);
			}
		}

		public dynamic? Get(string key)
		{
			if(Settings.TryGetValue(key, out dynamic? value))
			{
				return value;
			}
			else
			{
				return null;
			}
		}

		public dynamic? this[string s]
		{
			get
			{
				return Get(s);
			}
			set
			{
				Set(s, value);
			}
		}
	}
}
