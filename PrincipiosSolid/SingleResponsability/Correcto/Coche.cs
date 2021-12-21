using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.SingleResponsability.Correcto
{
    class Coche
    {
        String marca;

        Coche(String marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }
    }
}
