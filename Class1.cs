using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class ColoredLamp : Garland
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public string State { get; set; }
        public int Count;
        public int ColoredCount;
        public int i;

        public override void CurrentState()
        {
            Console.WriteLine("How many lamps in the colored garland");
            Garland colorednumber = new ColoredLamp();
            ColoredCount=colorednumber.CheckNumber();
            Console.WriteLine("Count of lamps is" + ColoredCount);



            List<ColoredLamp> ColoredLampList = new List<ColoredLamp> // Populate List


            { new ColoredLamp { ID=1, Color = "a", State = "a"} };
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
                    return Count;
                }

            }
            return Count;
        }

    }
}
