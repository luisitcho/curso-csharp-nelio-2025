
using System;
using System.Globalization;

class Program {
    static void Main() {
        //string frase = Console.ReadLine();
        //string x = Console.ReadLine();
        //string y = Console.ReadLine();
        //string z = Console.ReadLine();

        //Console.WriteLine($"Você digitou na frase: {frase}");
        //Console.WriteLine($"Você digitou no X: {x}");
        //Console.WriteLine($"Você digitou no Y: {y}");
        //Console.WriteLine($"Você digitou no Z: {z}");


        //string[] v = Console.ReadLine().Split(' ');
        //string a = v[0];
        //string b = v[1];
        //string c = v[2];

        //Console.WriteLine($"Você digitou no A: {a}");
        //Console.WriteLine($"Você digitou no B: {b}");
        //Console.WriteLine($"Você digitou no C: {c}");


        //int n1 = int.Parse(Console.ReadLine());
        //char ch = char.Parse(Console.ReadLine());
        //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Console.WriteLine($"Você digitou no N1: {n1}");
        //Console.WriteLine($"Você digitou no CH: {ch}");
        //Console.WriteLine($"Você digitou no N2: {n2}");


        string[] frase = Console.ReadLine().Split(' ');
        string nome = frase[0];
        char sexo = char.Parse(frase[1]);
        int idade = int.Parse(frase[2]);
        double altura = double.Parse(frase[3], CultureInfo.InvariantCulture);

        Console.WriteLine($"Você digitou no NOME: {nome}");
        Console.WriteLine($"Você digitou no SEXO: {sexo}");
        Console.WriteLine($"Você digitou no IDADE: {idade}");
        Console.WriteLine($"Você digitou no ALTURA: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
