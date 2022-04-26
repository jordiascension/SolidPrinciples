
using PrincipiosSolid.InterfaceSegregation.InCorrecto;
using System;

namespace PrincipiosSolid.InterfaceSegregation.Incorrecto
{
    public class BurgerOrderService : IOrderService
    {
        public void orderBurger(int quantity)
        {
            Console.WriteLine("Number of Burgers " + quantity.ToString());
        }

        public void orderCombo(int quantity, int fries)
        {
            throw new System.NotImplementedException("No fries in burger only order");
        }

        public void orderFries(int fries)
        {
            throw new System.NotImplementedException("No combo in burger only order");
        }
    }
}
