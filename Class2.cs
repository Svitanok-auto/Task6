using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class OrdinaryLamp : Garland
    {
        public int ID { get; set; }
        public string State { get; set; }
        public int Count;
        public int OrdinaryCount;
        public int i;
        public override void CurrentState()
        {
            Console.WriteLine("How many lamps in the ordinary garland");
            Garland ordinarynumber = new OrdinaryLamp();
            OrdinaryCount = ordinarynumber.CheckNumber();
            Console.WriteLine("Count of lamps is" + OrdinaryCount);

            List<OrdinaryLamp> ColoredLampList = new List<OrdinaryLamp> // Populate List
            { new OrdinaryLamp {ID=1, State = "a"} };
        }

        public override int CheckNumber()
        {
            while (i < 10)
            {

                string InputString = Console.ReadLine();
                if (InputString.ToString() != string.Empty) // the Convert fails when ""
                {
                    try
                    {
                        Count = Convert.ToInt32(InputString);
                        Console.WriteLine("Count is  " + Count);
                        return Count;
                        break;
                    }
                    catch (SystemException sex)
                    {
                        // this class's error string
                        string LastError = sex.Message;
                        Console.WriteLine("Incorrect Input, error" + LastError);
                        Console.WriteLine("Try again to populate correct count");
                        i++;

                    }

                }

                else
                {
                    Console.WriteLine("Empty input");

                }

            }
            return Count;
        }
    }
}
