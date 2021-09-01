using System;

namespace Detector_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                string Input = Console.ReadLine(); //Read User Input.
                Console.ReadKey();
                int numericValue;
                if (int.TryParse(Input, out numericValue) == true) //Test if string contains a number or if just a string with letters.
                {
                    if (numericValue < 2 && numericValue > -1) //Check if converted number is a bool.
                    {
                        Console.WriteLine("Input " + Input + " is a Boolean or an integer.");
                    }
                    else
                    {
                        Console.WriteLine("Input " + Input + " is a an Integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Input " + Input + " is a string.");
                }
            }

        }
    }
}
