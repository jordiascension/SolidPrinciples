

namespace PrincipiosSolid.LiskovSubstitution.Correcto
{
    class Audi : Coche
    {
        public override int precioMedioCoche()
        {
            return 25000;
        }

        public override int numAsientos()
        {
            return 5;
        }
    }
}
