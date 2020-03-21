using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCourceOOPBasics
{
    class Modificators
    {
        public int Field;
    }

    class Radio
    {
        Radio() { }
    }

    internal class Radio1
    {
        private Radio1()
        {
        }
    }

    public class Radio2
    {
        public Radio2() { }
    }
}
