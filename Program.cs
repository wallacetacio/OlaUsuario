using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDigitado;
            Console.Write("Por gentileza, digite seu nome: ");
            nomeDigitado = Console.ReadLine();
            Console.WriteLine($"Olá {nomeDigitado}!");
        }
    }
}
