﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Interfaces
{
	public interface IGenerator<T>
	{
		T Generate();
	}
}
