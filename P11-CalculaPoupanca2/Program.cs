using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

        //int mes = 1;
        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);

            //mes = mes + 1;
            mes += 1;
        }
        */
        for (int mes = 1; mes <= 12; mes += mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}