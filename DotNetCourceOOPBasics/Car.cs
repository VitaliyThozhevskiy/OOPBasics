using System;

namespace DotNetCourceOOPBasics.Cars
{
    /*
     *overloaded standart ctor
     *keyword this
     *ctors chain
     * optional params in ctors
     */
    public class Car
    {
        private string Name;
        protected int Speed { get; set; }

        public static int Type = 0;

        static Car()
        {
            Type = 1;
        }

        public Car()
        {
            Name = "Chuck";
            Speed = 10;
        }

        public Car(string Name, int speed = 30)
        {
            if(speed < 0)

            this.Name = Name;
            Speed = speed;
            Display();
        }

        public virtual int GetSpeed()
        {
            SetSpeed(30);
            return Speed;
        }

        public void SetSpeed(int speed)
        {
            GetSpeed();
            //if(s)
            Speed = speed;
        }

        public void PrintState() => Console.WriteLine("{0} is going {1} MPH.", Name, Speed);
        public void Speedup(int delta) => Speed += delta;
        public void Run()
        {
            Console.WriteLine("Car");
        }

        public static void Display()
        {
            Type = 0;
        }
    }
}