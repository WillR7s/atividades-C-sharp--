using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class Carro :Veiculo
    {
        public int QuantidadePortas {get;set;}

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade De Portas:{QuantidadePortas}");
        }
    }
}