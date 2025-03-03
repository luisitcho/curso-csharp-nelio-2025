using System;
using System.Globalization;
class Program {
    static void Main() {
        bool completo = false;
        char genero = 'F';
        char letra = '\u0041';
        int idade = 32;
        byte n1 = 126;
        int n2 = 1000;
        int n3 = 2147483647;
        long n4 = 2147483648L;
        float n5 = 4.5f;
        double n6 = 4.5;
        double saldo = 10.35784;
        String nome = "Maria Green";
        Object obj1 = "Alex Brown";
        Object obj2 = 4.5f;


        Console.WriteLine(completo);
        Console.WriteLine(genero);
        Console.WriteLine(letra);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(nome);
        Console.WriteLine(obj1);
        Console.WriteLine(obj2);

        Console.WriteLine(21.47483648.ToString("F2"));
        Console.WriteLine(21.47483648.ToString("F3"));
        Console.WriteLine(21.47483648.ToString("F4", CultureInfo.InvariantCulture));

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
        Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");



        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";
        //byte idade = 30;
        int codigo = 5290;
        //char genero = 'M';
        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
        Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
        Console.WriteLine();
        Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
        Console.WriteLine();
        Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
        Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));



        //double a;
        //float b;

        //a = 5.1;
        //b = (float)a;

        //Console.WriteLine(b);


        //double a;
        //int b;

        //a = 5.1;
        //b = (int)a;

        //Console.WriteLine(b);


        int a = 5;
        int b = 2;

        double resultado = (double)a / b;

        Console.WriteLine(resultado);


        if (b % 2 == 0) {
            Console.WriteLine("Par");
        } else {
            Console.WriteLine("Impar");
        }


        int n1_1 = 3 + 4 * 2;
        int n2_2 = (3 + 4) * 2;
        int n3_3 = 17 % 3;
        double n4_4 = 10.0 / 8.0;
        double a_a = 1.0, b_b = -3.0, c_c = -4.0;
        double delta = Math.Pow(b_b, 2.0) - 4.0 * a_a * c_c;
        double x1 = (-b_b + Math.Sqrt(delta)) / (2.0 * a_a);
        double x2 = (-b_b - Math.Sqrt(delta)) / (2.0 * a_a);

        Console.WriteLine(n1_1);
        Console.WriteLine(n2_2);
        Console.WriteLine(n3_3);
        Console.WriteLine(n4_4);
        Console.WriteLine(delta);
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }
}