using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
public abstract class Garland
    {
        public abstract void CurrentState();
        public abstract int CheckNumber();
    }


    class Program
    {
        static void Main(string[] args)
        {
            Garland garland1 = new ColoredLamp();
            garland1.CurrentState();

            Garland garland2 = new OrdinaryLamp();
            garland2.CurrentState();

        }
    }
}
