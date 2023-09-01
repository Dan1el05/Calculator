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
        private int lastResult;

        public static int Addition(int a, int b)
        {
            int lastResult = a + b;
            return lastResult;
        }

        public static int Subtraktion(int a, int b)
        {
            int lastResult = a - b;
            return lastResult;
        }

        public static int Multiplikation(int a, int b)
        {
            int lastResult = a * b;
            return lastResult;
        }

        public static int Division(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Die Eingabe ist null. Bitte gebe eine Ganza zahl ein: ");
            }

            int lastResult = a / b;
            return lastResult;
        }

        public static int ReadInt(string promt)
        {
            Console.WriteLine(promt);
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, o33ut number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                }
            }
        }

        public static void Schow( int a, int b, int lastResult)
        {
            Console.WriteLine($"Das Ergebnis von {a} und {b} ist {lastResult}");
        }


        public int GetLastResult()
        {
            return lastResult;
        }
    }
}
