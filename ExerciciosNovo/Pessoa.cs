public class Pessoa
{

public string? Nome { get; set; }
public int Idade {get; set;}
public string? Cidade  {get; set;}


public void Apresentar()
{
    Console.WriteLine($"""
    Ola Meu nome é {Nome},
    Tenho {Idade} Anos,
    Moro em {Cidade}.
    """);
}


}