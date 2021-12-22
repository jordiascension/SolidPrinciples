using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.OpenClose.Incorrecto
{
    public class Coche
    {


        private String marca;

        public String Marca { get; set; }

        public Coche(String marca) { this.marca = marca; }

        public String getMarcaCoche() { return marca; }
    }
}
