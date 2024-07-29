using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Structures
{
    public class Currency
    {
        public string Code { get; set; }
        public string Symbol { get; set; }

        private Currency(string code, string symbol)
        {
            Code = code;
            Symbol = symbol;
        }

        public static Currency? Get(string code)
        {
            if (Map.TryGetValue(code, out var symbol))
            {
                return new Currency(code, symbol);
            }

            return null;
        }

        private static Dictionary<string, string> Map = new Dictionary<string, string>
        {
            { "USD", "$" },
            { "EUR", "€" },
            { "GBP", "£" },
            { "JPY", "¥" },
            { "AUD", "A$" },
            { "CAD", "C$" },
            { "CHF", "CHF" },
            { "CNY", "¥" },
            { "INR", "₹" },
            { "BRL", "R$" },
            { "ZAR", "R" },
            { "RUB", "₽" },
            { "MXN", "$" },
            { "SGD", "S$" },
            { "HKD", "HK$" },
            { "NZD", "NZ$" },
            { "KRW", "₩" },
            { "TRY", "₺" },
            { "SAR", "ر.س" },
            { "AED", "د.إ" },
            { "ARS", "$" },
            { "CLP", "$" },
            { "COP", "$" },
            { "EGP", "ج.م" },
            { "GHS", "GH₵" },
            { "ISK", "kr" },
            { "KES", "KSh" },
            { "NGN", "₦" },
            { "PKR", "₨" },
            { "PEN", "S/" },
            { "PLN", "zł" },
            { "UAH", "₴" },
            { "VND", "₫" }
        };


    }

}
