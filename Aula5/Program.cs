
using System;
using System.Globalization;

class Program {
    static void Main() {

        Console.WriteLine("Enter a number: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (x >= 0) {
            double squareRoot = Math.Sqrt(x);
            Console.WriteLine(squareRoot.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Enter another number: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Negative number!");
    }
}
