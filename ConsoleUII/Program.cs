using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetById())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
