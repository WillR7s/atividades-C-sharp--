using System.Security.Cryptography.X509Certificates;

public class Funcionario
{
    public string? Nome { get; set; }
    public string? Cargo { get; set; }
    public double Salario { get; set; }
    public double Percentual { get; set; }

    public void AumentarSalario()
    {
        // O cálculo é feito aqui dentro!
        double aumento = Salario + (Salario * (Percentual / 100));

        Console.WriteLine($"Novo Salario do Funcionario {Nome} é R$ {aumento}");
    }

    public void ConsultarSalario()
    {
        Console.WriteLine($"O Salário do funcionario {Nome} é R$ {Salario} ");
    }
}