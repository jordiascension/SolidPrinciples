using System;
using System.Collections.Generic;
using System.Text;


/*
 Para que este método cumpla con el principio, seguiremos estos principios:

Si la superclase (Coche) tiene un método que acepta un parámetro del tipo de 
la superclase (Coche), entonces su subclase (Renault) debería aceptar como 
argumento un tipo de la superclase (Coche) o un tipo de la subclase (Renault).

Si la superclase devuelve un tipo de ella misma (Coche), entonces su subclase 
(Renault) debería devolver un tipo de la superclase (Coche) o un tipo de la 
subclase (Renault).

 */
namespace PrincipiosSolid.LiskovSubstitution.Correcto
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

        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }
    }
}
