namespace Calculator
{
    internal class Program
    {
        public static object Break { get; private set; }

        static void Main(string[] args)
        {
           
            Calculator calculator = new Calculator();

            Console.WriteLine("Addition");
            int result = Calculator.ReadInt("Geben sie die erste Zahl ein: ");
            int b = Calculator.ReadInt("Geben soe die zweite zahl ein ");
            result = Calculator.PerformOperation(result, b, Calculator.Addition);
            Console.WriteLine("Ergebnis " + result);





         Console.WriteLine("Subtraktion");
         int d = Calculator.ReadInt("Geben sie die zweite Zahl ein ");
         result = Calculator.PerformOperation(result, d, Calculator.Subtraktion);
         Console.WriteLine("letztes Ergebnis minus zweite Zahl = " + result); ;




        Console.WriteLine("Multiplikation");
        int f = Calculator.ReadInt("Geben sie die zweite Zahl ein ");
         result = Calculator.PerformOperation(result, f, Calculator.Multiplikation);
        Console.WriteLine("letztes Ergebnis mal zweite zahl = " + result);

            Console.WriteLine("Division");
            int h = Calculator.ReadInt("Geben sie die zweite Zahl ein ");
            result = Calculator.PerformOperation(result, b, Calculator.Division);
            Console.WriteLine("letztes Ergebnis durch zweite zahl = " + result);
           
        }
    }
 }
