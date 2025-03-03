
using System;

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

        
        string[] v = Console.ReadLine().Split(' ');
        string a = v[0];
        string b = v[1];
        string c = v[2];

        Console.WriteLine($"Você digitou no A: {a}");
        Console.WriteLine($"Você digitou no B: {b}");
        Console.WriteLine($"Você digitou no C: {c}");

    }
}
