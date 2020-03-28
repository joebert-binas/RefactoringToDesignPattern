using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringToDesignPattern.Factory
{
    public static class PizzeriaFactory
    {
        public static IPizzeria Get(PizzeriaType pizzeriaType)
        {
            switch (pizzeriaType)
            {
                case PizzeriaType.A: return  new PizzeriaA();
                case PizzeriaType.B: return new PizzeriaB();
            }

            return null;
        }
    }
}
