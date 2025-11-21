using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;

namespace ExerciciosCsharp.ManipulateStrings
{
   public class Exercicio6
{
    public static string InverterString(string? texto, bool trim = false, bool ignoreInnerSpaces = false, int maxLength = 1_000 )
        {
            if (string.IsNullOrEmpty(texto))
            throw new ArgumentException(" A string não pode ser vazia ou nulo!");

            if (trim)
            texto = texto.Trim();

            if (ignoreInnerSpaces)
                texto = texto.Replace(" ", string.Empty);

            if (texto.Length > maxLength)
                throw new ArgumentException("O texto é muito grande , número máximo permitido de 1000 caracter");

            if (Regex.IsMatch(texto, @"\d"))
            throw new ArgumentException("Números não permitidos, Digite apenas textos.");
           
            
            StringBuilder resultado = new StringBuilder(texto.Length); // mais eficiente para texto longos 
            for (int i = texto.Length -1; i >= 0; i--)
            {
                resultado.Append(texto[i]);
                
            }
            return resultado.ToString();
        }
} 
}


// Inverte  string recebida (remover os espaços nas extremidades, TRIM,  remove espaço interno REPLACE, limitar o tamanho da string)

//StringBuilder funciona como um buffer de caracteres
//Ao invés de criar várias strings na memória, ele acumula tudo e só monta o texto no final , mais rápido e eficiente.
// Documentação 
// Regex  https://learn.microsoft.com/dotnet/standard/base-types/regular-expressions
// StringBuilder https://learn.microsoft.com/dotnet/api/system.text.stringbuilder
// Validação e Exceções https://learn.microsoft.com/dotnet/standard/exceptions/
// Strings https://learn.microsoft.com/dotnet/api/system.string