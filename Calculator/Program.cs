namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Calculator calculator = new Calculator();

            int a = Calculator.ReadInt("Geben sie eine Zahl ein: ");
          int b = Calculator.ReadInt("Geben sie eine Zahl ein ");
          int sum = Calculator.Addition(a, b);
          Calculator.Schow(a, b, sum);




         int c = Calculator.ReadInt("Geben sie eine Zahl ein ");
         int d = Calculator.ReadInt("Geben sie eine Zahl ein ");
         int sumSub = Calculator.Subtraktion(c, d);
         Calculator.Schow( c, d, sumSub);
                

            
                
         int e = Calculator.ReadInt("Geben sie eine Zahl ein: ");
         int f = Calculator.ReadInt("Geben sie eine Zahl ein ");
         int sumMu = Calculator.Multiplikation(e, f);
         Calculator.Schow(e, f, sumMu);
                

                
         int g = Calculator.ReadInt("Geben sie eine Zahl ein: ");
         int h = Calculator.ReadInt("Geben sie eine Zahl ein ");
         int sumDiv = Calculator.Division(g, h);
         Calculator.Schow(g, h, sumDiv);
            int lastResult = calculator.GetLastResult();
            Console.WriteLine("Das letzte resultat ist" + lastResult);

        }
    }
 }
