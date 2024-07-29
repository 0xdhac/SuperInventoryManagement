using SIM_SharedLib.Interfaces;
using SIM_SharedLib.Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIM_SharedLib.Validators
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class USDPriceValidator : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			if(value == null)
			{
				return new ValidationResult("Null value for price.");
			}

			double number = (double)value;

			if (number < 0)
			{
				return new ValidationResult("Price cannot be less than 0");
			}

			double rounded = Math.Round(number, 2);

			if(Math.Abs(rounded - number) > 0)
			{
				return new ValidationResult("Price must be a number rounded down to the minimal denomination of the current currency.");
			}

			return new ValidationResult("Incorrect phone number format.");
		}
	}
}
