using System;
using RefactoringToDesignPattern.Factory;

namespace RefactoringToDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Electric Kettle
            var electricKettle = ElectricKettle.Instance;

            electricKettle.ChangeStatus(ElectricKettle.Status.Empty);
            electricKettle.Fill();

            electricKettle.ChangeStatus(ElectricKettle.Status.InProgress);
            electricKettle.Boil();

            electricKettle.ChangeStatus(ElectricKettle.Status.Boiled);
            electricKettle.Drain();

            //Pizzeria   
            var pizzeriaA = PizzeriaFactory.Get(PizzeriaType.A);
            pizzeriaA.Order(PizzaType.Cheese);
            pizzeriaA.Order(PizzaType.Clam);
            pizzeriaA.Order(PizzaType.Veggie);
       
            var pizzeriaB = PizzeriaFactory.Get(PizzeriaType.B);
            pizzeriaB.Order(PizzaType.Cheese);
            pizzeriaB.Order(PizzaType.Clam);
            pizzeriaB.Order(PizzaType.Veggie);

        }
    }
}
