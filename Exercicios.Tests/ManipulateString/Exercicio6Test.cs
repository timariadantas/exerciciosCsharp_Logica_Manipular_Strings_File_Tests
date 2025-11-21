using ExerciciosCsharp.ManipulateStrings;
using Xunit;

namespace Exercicios.Tests.ManipulateString
{
    public class Exercicio6Tests
    {
        [Theory]
        [InlineData("Maria", "airaM")]
        [InlineData("Gustavo", "ovatsuG")]
        public void Deve_Inverter(string texto, string resultadoEsperado)
        {
            var resultado = Exercicio6.InverterString(texto);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Deve_Remover_Espacos_Trim()
        {
            var resultado = Exercicio6.InverterString(" teste ", trim: true);
            Assert.Equal("etset", resultado);
        }
        [Fact]
         public void Deve_Ignorar_Espacos_Internos_IgnoreInnerSpaces()
        {
            var resultado = Exercicio6.InverterString("a b c", ignoreInnerSpaces: true);
            Assert.Equal("cba", resultado);
        }

        [Fact]
        public void Deve_Lancar_Erro_Texto_Null_Vazio()
        {
            Assert.Throws<ArgumentException>(()=> Exercicio6.InverterString(""));
            Assert.Throws<ArgumentException>(()=> Exercicio6.InverterString(null));
        }

    [Fact]
    public void Deve_Lancar_Erro_Texto_Passar_Limite()
        {
            string textoGrande = new string('a', 1500);
            Assert.Throws<ArgumentException>(()=> Exercicio6.InverterString(textoGrande));
        }

        [Fact]
        public void Deve_Lancar_Erro_Quando_Tiver_Numero()
        {
            Assert.Throws<ArgumentException>(() => Exercicio6.InverterString("T8"));
        }

            
        
    }
}


// doc test https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-csharp-with-xunit