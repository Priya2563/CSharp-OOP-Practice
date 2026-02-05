namespace PolymorphismMethodOverloading
{//Polymorpism ka Method Overloading
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3));        // 5
            Console.WriteLine(calc.Add(2.5, 3.5));    // 6.0
            Console.WriteLine(calc.Add(1, 2, 3));     // 6

        }
    }
}
