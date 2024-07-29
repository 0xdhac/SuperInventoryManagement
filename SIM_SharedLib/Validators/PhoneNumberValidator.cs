using SIM_SharedLib.Interfaces;
using SIM_SharedLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;

namespace SIM_SharedLib.Validators
{
	/*
	public class PhoneNumberValidator : IValidator<PhoneNumber>
	{
		public bool IsValid(PhoneNumber obj)
		{
			// Define a regular expression pattern for a valid phone number
			string pattern = @"^\+?[1-9]\d{1,14}$";

			// Create a Regex object with the pattern
			Regex regex = new Regex(pattern);

			// Check if the phone number matches the pattern
			return regex.IsMatch(obj.Value);
		}

		bool IValidator.IsValid(object obj)
		{
			return IsValid((PhoneNumber)obj);
		}
	}
	*/

	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class PhoneNumberValidator : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			string? number = value as string;

			if (number == null)
			{
				return new ValidationResult("Null value for phone number.");
			}

			// Define a regular expression pattern for a valid phone number
			string pattern = @"^\+?[1-9]\d{1,14}$";

			// Create a Regex object with the pattern
			Regex regex = new Regex(pattern);

			// Check if the phone number matches the pattern
			if (regex.IsMatch(number))
			{
				return ValidationResult.Success;
			}

			return new ValidationResult("Incorrect phone number format.");
		}
	}
}
