using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringToDesignPattern
{
    public class ElectricKettle
    {
        private static ElectricKettle _instance = new ElectricKettle();

        private ElectricKettle()
        {
            Console.WriteLine("Starting");
        }

        public static ElectricKettle Instance => _instance;

        public enum Status
        {
            Empty = 1,
            InProgress = 2,
            Boiled = 3
        }

        private Status _currentStatus = Status.Empty;



        public void Fill()
        {
            Console.WriteLine("Filling");
        }
        public void Boil()
        {
            Console.WriteLine("Boiling");
        }
        public void Drain()
        {
            Console.WriteLine("Draining");

        }

        public void ChangeStatus(Status status)
        {
            _currentStatus = status;
        }


    }
}
