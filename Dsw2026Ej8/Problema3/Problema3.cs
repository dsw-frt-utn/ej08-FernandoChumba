using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    public class Problema3
    {
        public string ComprarCopias(int originalValue, Product product)
        {
            int copiaValue = originalValue;

            copiaValue++;

            Product copiaProduct = product;

            copiaProduct.Description = "Producto Modificado";

            return $"{originalValue} - {copiaValue} - {product.Description}";


        }
    }
}
