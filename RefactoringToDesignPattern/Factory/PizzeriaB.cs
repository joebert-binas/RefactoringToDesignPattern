using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringToDesignPattern.Factory
{
    public class PizzeriaB : IPizzeria
    {
        private PizzaType _pizzaType;

        private PizzaIngredient _ingredient = new PizzaIngredient()
        {
            Cheese = "Parmesan",
            Clam = "Frozen Clam",
            Dough = "Thin Crust",
            Sauce = "Plum Tomato",
            Veggies = "Olives, Onions, Bell Peppers"
        };

        public void Order(PizzaType pizzaType)
        {
            this._pizzaType = pizzaType;

            Prepare();
            Bake();
            Cut();
            Box();
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing Pizzeria B Style {_pizzaType.ToString()} Using");

            switch (_pizzaType)
            {
                case PizzaType.Cheese:
                    Console.WriteLine($"Dough: {_ingredient.Dough}, Cheese: {_ingredient.Cheese}, Sauce: {_ingredient.Sauce}, Veggies: {_ingredient.Veggies}"); break;
                case PizzaType.Clam:
                    Console.WriteLine($"Dough: {_ingredient.Dough}, Clam: {_ingredient.Clam}, Sauce: {_ingredient.Sauce}, Cheese: {_ingredient.Cheese}"); break;
                case PizzaType.Veggie:
                    Console.WriteLine($"Dough: {_ingredient.Dough}, Sauce: {_ingredient.Sauce}, Veggies: {_ingredient.Veggies}"); break;
            }
        }

        public void Bake()
        {
            Console.WriteLine("Baking at 135 degree Celsius for 25 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting into diagonal pieces");
        }

        public void Box()
        {
            Console.WriteLine("Putting pizza in Green coloured box");
        }
    }
}
