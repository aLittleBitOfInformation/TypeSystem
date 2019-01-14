using System;

namespace TypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Type stringType = typeof(string);
            Console.WriteLine(stringType.Attributes);

            string currency = $"{2.5:C}";
            Console.Write("Currency:    $\"{2.5:C}\"    ");
            Console.WriteLine(currency);

            decimal value = 2.5M;
            string fixedPoint = $"{value:F2}";
            Console.Write("Fixed Point: $\"{2.5:F2}\"   ");
            Console.WriteLine(fixedPoint);

            decimal percentageValue = 0.25M;
            string percentage = $"{percentageValue:P}";
            Console.Write("Percentage:  $\"{0.25:P}\"   ");
            Console.WriteLine(percentage);
        }
    }
}
