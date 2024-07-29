using SIM_SharedLib.Registries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Core
{
	public struct SIMContext
	{
		public Config SIM_Configuration { get; set; }
		public CategoryRegistry SIM_ProductCategories { get; set; }
		public CurrencyRegistry SIM_Currencies { get; set; }
		public ValidatorRegistry SIM_Validators { get; set; }
		public WarehouseRegistry SIM_WarehouseRegistry { get; set; }
		public BinRegistry SIM_BinRegistry { get; set; }
	}
}
