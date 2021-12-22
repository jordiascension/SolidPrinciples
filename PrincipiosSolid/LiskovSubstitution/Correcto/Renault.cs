using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.LiskovSubstitution.Correcto
{
    class Renault : Coche
    {
        public override int precioMedioCoche()
        {
            return 18000;
        }

        public override int numAsientos()
        {
            return 4;
        }
    }
}
