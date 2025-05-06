using Aula7;
using System;
using System.Globalization;

class Program {
    static void Main() {

        // Código sem orientação a objetos
        double xA, xB, xC, yA, yB, yC;

        Console.WriteLine("Entre com as medidas triângulo X:");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas triângulo Y:");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double p = (xA + xB + xC) / 2.0;
        double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2.0;
        double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY) {
            Console.WriteLine("Maior área: X");
        } else {
            Console.WriteLine("Maior área: Y");
        }


        // Código com orientação a objetos
        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas triângulo X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas triângulo Y:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX2 = x.CalcularArea();
        double areaY2 = y.CalcularArea();

        Console.WriteLine("Área de X = " + areaX2.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + areaY2.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX2 > areaY2) {
            Console.WriteLine("Maior área: X");
        } else {
            Console.WriteLine("Maior área: Y");
        }
    }
}

class Triangulo {
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public double CalcularArea() {
        double p = (A + B + C) / 2.0;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
