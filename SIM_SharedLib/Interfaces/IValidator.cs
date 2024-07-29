using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Interfaces
{
    // Third party extensions need to be able to modify the validator of all classes
	public interface IValidator
	{
		bool IsValid(object obj);
	}

    public interface IValidator<T> : IValidator
    {
        public bool IsValid(T obj);
    }
}