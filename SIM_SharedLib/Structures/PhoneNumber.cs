using SIM_SharedLib.Interfaces;

namespace SIM_SharedLib.Structures
{
    public class PhoneNumber
    {
        public string Value { get; set; }

        public PhoneNumber(string value)
        {
			Value = value;
        }

        public override string ToString() { return Value; }
	}
}
