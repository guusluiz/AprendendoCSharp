using System;

class Programa
{
    static void Main(string[] args)
    {
        int fatorial = 1;
        for (int n = 1; n <= 10; n++)
        {
            fatorial = fatorial * n;
            Console.WriteLine("Fatorial de " + n + " = " + fatorial);
        }
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}