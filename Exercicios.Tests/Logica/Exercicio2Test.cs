using ExerciciosCsharp.Logica;
using Xunit; 

namespace Exercicios.Tests.Logica;

public class Exercicio2Test
{
    [Theory]
        [InlineData(10, 5, "+", 15)]
        [InlineData(10, 5, "-", 5)]
        [InlineData(10, 5, "*", 50)]
        [InlineData(10, 5, "/", 2)]

        public void Deve_Calcular(double num1 , double num2, string operacao , double resultadoEsperado)
    {
        //// act (executar o código que queremos testar)
        var resultado = Exercicio2.Calculadora(num1 , num2 , operacao);

        // // assert (verificar o resultado)
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Deve_Lancar_Erro_Dividir_Zero()
    {
        Assert.Throws<DivideByZeroException>(()=> Exercicio2.Calculadora(10,0,"/"));
    }
}
