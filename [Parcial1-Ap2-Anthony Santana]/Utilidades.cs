using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _Parcial1_Ap2_Anthony_Santana_
{
    public class Utilidades
    {
        public static int TOINT(string nombre)
        {
            int numero;
            int.TryParse(nombre, out numero);
            return numero;
        }
    }
}