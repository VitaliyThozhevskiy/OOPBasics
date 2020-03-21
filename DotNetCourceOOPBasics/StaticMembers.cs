using System;

namespace DotNetCourceOOPBasics
{
    class SavingsAccount
    {
        public double Balance;
        public static double InterestRate = 0.04;

        //static ctor

        public SavingsAccount(double balance)
        {
            Balance = balance;
        }

        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return InterestRate;
        }
    }

    static class TimeUtilClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }
}