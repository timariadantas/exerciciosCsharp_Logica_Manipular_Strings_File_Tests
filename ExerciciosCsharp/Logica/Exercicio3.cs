namespace Exercicios_Csharp_november.Logica
{
    public class Exercicios3
    {
        public static long Fatorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("Não existe fatorial de é número negativo ");
            }

            long resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}


// CALCULAR FACTORIAL basta multiplicar o número por todos os inteiros positivos menores que ele, até chegar a 1. 
// Por exemplo, o fatorial de 5  , 5 * 4 *3 * 2 * 1
// uso do for , controle de  índice	, quando precisa saber a posição ou manipular a ordem