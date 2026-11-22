using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class Ebook:ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

    public Ebook(string? nome, decimal preco, int quantidadePaginas) : base(nome, preco)
    {
    
        QuantidadePaginas=quantidadePaginas;
    }

     public override void ExibirProduto()
        {
            base.ExibirProduto();
            Console.WriteLine($"Quantidade de Paginas:{QuantidadePaginas}");
        }
    }
}