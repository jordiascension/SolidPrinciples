using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.LiskovSubstitution.Correcto
{
    class Mercedes : Coche
    {
        public override int precioMedioCoche()
        {
            return 27000;
        }

        public override int numAsientos()
        {
            return 4;
        }
    }
}
