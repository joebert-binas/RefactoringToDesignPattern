using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringToDesignPattern.Factory
{
    public interface IPizzeria
    {
        void Order(PizzaType pizzaType);
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
