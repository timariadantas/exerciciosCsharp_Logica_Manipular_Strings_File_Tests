namespace ExerciciosCsharp.Logica;

public class Exercicio2
{
    public static double Calculadora(double num1, double num2, string operacao)
    {
        if (operacao == "+")
            return num1 + num2;
        if (operacao == "-")
            return num1 - num2;
        if (operacao == "*")
            return num1 * num2;
        if (operacao == "/")
        {
            if(num2 ==0)
                throw new DivideByZeroException("Não é possivel dividir por zero.");
            return num1 / num2;
        }

        throw new ArgumentException("Operação Inválida.");
    }
}
