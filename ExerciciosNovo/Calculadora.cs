public class Calculadora 
{

public int Numero1 {get; set;}
public int Numero2 {get; set;}



public void Somar()
{
    int resultadoSoma = Numero1 + Numero2;
    Console.WriteLine($"O Resultado da Soma é : {resultadoSoma}");
}

public void Subtrair()
{
    int resultadoSubtrair = Numero1 - Numero2;
    Console.WriteLine($"O Resultado da Subtração é: {resultadoSubtrair}");
}

public void Multiplicar()
{
    int resultadoMulti = Numero1 * Numero2;
    Console.WriteLine($"O Resultado da Multiplicação é: {resultadoMulti}");
}

public void Dividir()
{
    double resultadoDivisao = double.Parse(Numero1.ToString()) / double.Parse(Numero2.ToString());

    Console.WriteLine($"O Resultado da divisão é: {resultadoDivisao}");
}

}