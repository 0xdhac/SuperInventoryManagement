using SIM_SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Interfaces
{
    public interface IDiscount
    {
        string Code { get; set; }
        void OnAddedToCart(Cart cart, Product product);
        void OnRemovedFromCart(Cart cart, Product product);
    }
}
