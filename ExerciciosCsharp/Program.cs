using System;
using ExerciciosCsharp.Logica;


class Program
{
    static void Main()
    {
        Console.WriteLine("Verifique se o número é par ou impar");
        Console.Write("DIGITE UM NUḾERO: ");
        string entrada = Console.ReadLine() ?? "0";

        if (int.TryParse(entrada, out int numero))
        {
            string resultado = Exercicio1.ParOuImpar(numero);
            Console.WriteLine ($"O numero {numero} é: {resultado}");

        }
        else
        {
            Console.WriteLine("Entrada Inválida. Tente novamente.");
        }
}
}