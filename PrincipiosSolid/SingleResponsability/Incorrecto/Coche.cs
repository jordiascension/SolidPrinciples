using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.SingleResponsability
{
    public class Coche
    {
        String marca;

        Coche(String marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }

        void guardarCocheDB(Coche coche)
        {

        }
    }
}
