using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class CursoOnline:ProdutoDigital
    {
        public int CargaHoraria {get;set;}

        
    public CursoOnline(string? nome, decimal preco, int cargaHoraria) : base(nome, preco)
    {
    
        CargaHoraria=cargaHoraria;
    }

   public override void ExibirProduto()
        {
            base.ExibirProduto();
            Console.WriteLine($"Carga Horaria:{CargaHoraria} Horas");
        } 
    }
}