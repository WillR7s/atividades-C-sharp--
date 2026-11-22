using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class Motocicleta:Veiculo
    {
        public int Cilindradas {get;set;}


        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Cilindradas:{Cilindradas}");
        }
    }
}