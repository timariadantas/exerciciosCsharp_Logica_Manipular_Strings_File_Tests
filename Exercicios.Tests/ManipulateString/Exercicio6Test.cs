using Xunit;
using ExerciciosCsharp.ManipulateStrings;

namespace Exercicios.Tests.ManipulateString
{
    public class Exercicio6Tests
    {
        [Fact]
        public void Deve_Inverter_String_Corretamente()
        {
            var resultado = Exercicio6.InverterString("Maria");
            Assert.Equal("airaM", resultado);
        }

        [Fact]
        public void Deve_Ignorar_Espacos_Internos_Quando_Solicitado()
        {
            var resultado = Exercicio6.InverterString("Ma ria", ignoreInnerSpaces: true);
            Assert.Equal("airaM", resultado);
        }

        [Fact]
        public void Deve_Lancar_Erro_Quando_Tiver_Numeros()
        {
            Assert.Throws<ArgumentException>(() => Exercicio6.InverterString("Maria123"));
        }

        [Fact]
        public void Deve_Lancar_Erro_Quando_Texto_Muito_Grande()
        {
            string texto = new string('a', 2000);
            Assert.Throws<ArgumentException>(() => Exercicio6.InverterString(texto));
        }
    }
}
