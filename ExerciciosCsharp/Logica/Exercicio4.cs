

namespace ExerciciosCsharp.Logica
{
    public class Exercicio4
    {
        public static double CalcularMedia(List<double> numeros)
        {
            if (numeros == null || numeros.Count == 0)
                throw new ArgumentException(" A lista está vazia.");

            double soma = 0;
            foreach (var n in numeros)
            {
                soma = soma + n;
            }
            double media = soma / numeros.Count;

            return media;
        }
    }
}


// CALCULAR A MEDIA, A média aritmética é quando somamos todos os valores e dividimos pela quantidade de valores.
// pra verficar dentro de uma coleção (Array usa .Length) ( List usa .Count)
// O foreach é um laço de repetição feito para percorra todos os itens de uma coleção, sem se preocupar com índice.