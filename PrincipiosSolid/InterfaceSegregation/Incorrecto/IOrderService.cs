using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.InterfaceSegregation.InCorrecto
{
    public interface IOrderService
    {
        void orderBurger(int quantity);
        void orderFries(int fries);
        void orderCombo(int quantity, int fries);
    }
}
