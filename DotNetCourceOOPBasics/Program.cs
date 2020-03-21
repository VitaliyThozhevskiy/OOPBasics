using DotNetCourceOOPBasics.Cars;
using System;
using System.Runtime.CompilerServices;
//[assembly: InternalsVisibleTo("someAssemblyName")]

namespace DotNetCourceOOPBasics
{
    class Program
    {
        //Car
        //Static members
        //OOP principles
        //modificators of access
        //properties and indexers
        //init props while creating
        //readonly fields and constants
        //partial classes
        //inheritance and polymorphism
        static void Main(string[] args)
        {
            Console.WriteLine("Lection5");
            Car car = new Car("");
            Minivan minivan = new Minivan();
            minivan.Run();
            Console.ReadKey();
        }

        static void Show(Car car)
        {
            //......
        }
    }
}
