using System;
using System.Collections;

namespace PrincipiosSolid.InterfaceSegregation.Incorrecto
{
    public class Calculator : ArrayList, IAdd, ISubstract
    {
        public int Add(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Substract(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}
