using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        public enum romanChar
        {
            M = 1000,
            CM = 900,
            D = 500,
            CD = 400,
            C = 100,
            XC = 90,
            L = 50,
            XL = 40,
            X = 10,
            IX = 9,
            V = 5,
            IV = 4,
            I = 1
        }
        // Convet arabic number into roman
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number !");

            int inputNumber = int.Parse(Console.ReadLine());

            Array values = Enum.GetValues(typeof(romanChar));
            Array.Reverse(values);

            string returnNumber = "";
            if (inputNumber > 9999)
            {
                Console.WriteLine("Your number is very height ! Impossible to convert !");
            } else
            {
                int arabicNumber = inputNumber;
                while (arabicNumber > 0)
                {
                    foreach (int value in values)
                    {
                        if (arabicNumber >= value)
                        {
                            arabicNumber -= value;
                            returnNumber += (romanChar)value;
                            break;
                        }
                    }
                }

                Console.WriteLine(inputNumber + " == " + returnNumber);
            }
        }
    }
}
