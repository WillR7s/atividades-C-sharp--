using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public abstract class ProdutoDigital
    {
        public string? Nome {get; set;}
        public Decimal Preco {get; set;}

public ProdutoDigital(string? nome , Decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
 public virtual void ExibirProduto()
        {
         Console.WriteLine($"Nome do Produto: {Nome}");   
         Console.WriteLine($"Preço do Produto: {Preco}");   
        }
    }

    
}