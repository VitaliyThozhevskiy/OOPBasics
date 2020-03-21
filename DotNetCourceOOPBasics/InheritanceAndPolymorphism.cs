using DotNetCourceOOPBasics.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCourceOOPBasics
{
    public class Minivan : Car
    {
        public override int GetSpeed()
        {
            base.Run();
            return 1;
        }

        public new void Run()
        {
            Console.WriteLine("Minivan");
        }
    }

    //make abstract
    public abstract class Employee
    {
        public Employee(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Work()
        {

        }
        public virtual void DoWork()
        {
            //....
        }
    }

    public class Manager : Employee
    {
        public new string Name { get; }
        public Manager(string name)
            : base(name)
        {

        }

        public new void DoWork()
        {
            base.DoWork();
            //......
        }

        public new void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Programer : Employee
    {
        public Programer()
            : base("")
        {

        }
        public override void DoWork()
        {
        }
    }
}
