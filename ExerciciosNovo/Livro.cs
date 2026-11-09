public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    // 1. Construtor sem parâmetros (valores padrão)
    public Livro()
    {
        Titulo = "Sem Título";
        Autor = "Desconhecido";
        NumeroPaginas = 0;
    }

    // 2. Construtor que recebe apenas o título
    public Livro(string titulo)
    {
        Titulo = titulo;
        Autor = "Desconhecido";
        NumeroPaginas = 0;
    }

    // 3. Construtor que recebe título e autor
    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = 0;
    }

    // 4. Construtor que recebe título, autor e número de páginas
    public Livro(string titulo, string autor, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    // Método auxiliar para exibir os dados do livro
    public void ExibirDados()
    {
        Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Páginas: {NumeroPaginas}");
    }
}