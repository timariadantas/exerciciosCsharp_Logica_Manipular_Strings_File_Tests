using Exercicios_Csharp_november.Logica;
using ExerciciosCsharp.Logica;


namespace Exercicio.Tests.Logica;

public class Exercicio3Test
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    public void Deve_calcular_Fatorial(int numero, long resultadoEsperado)
    {
        var resultado = Exercicios3.Fatorial(numero);
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Fact]
    public void Deve_Lancar_Erro_Numero_Negativo()
    {
        Assert.Throws<ArgumentException>(() => Exercicios3.Fatorial(-4));
    }
}
