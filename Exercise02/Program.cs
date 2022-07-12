using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excercise01;
using System.Numerics;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            user_input();

        }

        private static void user_input()
        {
            Console.WriteLine("Enter Number to Change to word:\nEnter x to exit");
            string number = Console.ReadLine();
            try
            {
                if(number.Equals("x"))
                {
                    Environment.Exit(0);
                }
                long num = long.Parse(number);
               
                String word = MathCalc.Towards(new BigInteger(num));
                Console.WriteLine(word);
                Console.WriteLine("-------------------------------------------------");
                user_input();
            }
            catch (Exception e)
            {
                user_input();
            }
        }
    }
}
