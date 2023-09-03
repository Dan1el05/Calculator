using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {

        public static int Addition(int a, int b)
        { 
            return a + b;
        }

        public static int Subtraktion(int a, int b)
        {
           
            return a-b;
        }

        public static int Multiplikation(int a, int b)
        {
           return a*b;
        }
        public static int Division(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Die Eingabe ist null. Bitte gebe eine Ganzahl ein: ");
            }

            return a / b;
        }


        public static int ReadInt(string promt)
        {
            Console.WriteLine(promt);
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                }
            }
        }

        public static int PerformOperation(int operand1, int operand2, Func<int, int, int> operation)
        {
           return operation(operand1, operand2);
        }

    }
}
