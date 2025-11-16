using ExerciciosCsharp.Logica;


namespace Exercicios.Tests.Logica;

public class Exercicio4Test
{
    [Theory]
    [InlineData(new double [] {10, 10, 10}, 10)]
    [InlineData(new double [] {2, 2, 2}, 2)]

    public void Deve_Calcular_Media(double[] numeros, double resultadoEsperado)
    {
        var lista = new List<double>(numeros);
        var resultado = Exercicio4.CalcularMedia(lista);

        Assert.Equal(resultadoEsperado,resultado);

    }
    [Fact]
    public void Deve_Lancar_Erro_Lista_Vazia()
    {
        var lista = new List<double>();
        Assert.Throws<ArgumentException>(() => Exercicio4.CalcularMedia(lista));
    }
}
