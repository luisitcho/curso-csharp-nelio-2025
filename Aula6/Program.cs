
using System;

class Program {
    static void Main() {
        Console.Write("Quantos números inteiros você vai digitar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) {
            Console.Write("Valor #{0}: ", i);
            int x = int.Parse(Console.ReadLine());
        }
    }
}
