using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.OpenClose.Incorrecto
{
    class Principal
    {
        public static void main(String[] args)
        {
            Coche[] arrayCoches = {
            new Coche("Renault"),
            new Coche("Audi")
    };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche.Marca == "Renault")
                    Console.Out.WriteLine(1800);
                if (coche.Marca == "Audi")
                    Console.Out.WriteLine(1800);
            }
        }
    }
}
