public class Veiculo
{
    public double Velocidade { get; set; }

    public void VerificarVelocidade()
    {
        if (Velocidade < 0 || Velocidade > 200)
        {
            Console.WriteLine("Valor de Velocidade Inválida");
            Console.WriteLine($"Valor inserido: {Velocidade}");
        }
        else
        {
            Console.WriteLine($"O Valor de Velocidade é: {Velocidade} KM/h");
        }
    }
}