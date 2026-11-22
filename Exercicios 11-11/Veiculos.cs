using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public abstract class Veiculo
    {
        public string? Marca {get; set;}
        public string? Modelo {get;set;}

         public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}.");
            Console.WriteLine($"Modelo: {Modelo}.");


        }

    }
}