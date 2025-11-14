using System;
using ExerciciosCsharp.Logica;

namespace Exercicios.Tests.Logica{

public class Exercicio1Test
{
    [Theory]  // Indica que o mesmo teste será executado várias vezes com valores diferentes.
    [InlineData(4, "É UM NÚMERO PAR")]
    [InlineData(9, "É UM NÚMERO IMPAR")]

    public  void deve_verificar_par_ou_impar(int numero, string resultadoEsperado)
    {
        // act (executar o código que queremos testar)
        string resultado = Exercicio1.ParOuImpar(numero);

        // assert (verificar o resultado)
        Assert.Equal(resultadoEsperado, resultado);
    }
}
}