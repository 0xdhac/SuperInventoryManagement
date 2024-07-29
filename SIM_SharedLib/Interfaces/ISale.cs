using SIM_SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_SharedLib.Interfaces
{
    public interface ISale
    {
        string Name { get; set; }
        string Description { get; set; }

        void OnItemAddedToCart(Cart cart, Product product);
        void OnItemRemovedFromCart(Cart cart, Product product);
    }
}
