using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema6
{
    public static class Extensiones
    {
        public static string ToProductCode(this string code)
        {
            return code?.Trim().ToUpper().Replace(" ", "-") ?? "SIN-CODIGO";
        }
    }
}