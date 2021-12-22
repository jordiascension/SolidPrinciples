using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.OpenClose.Correcto
{
    public class Principal
    {
        public static void main(String[] args)
        {

            Coche[] arrayCoches = {
                new Renault(),
                new Audi(),
                new Mercedes()
            };

            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }
    }
}
