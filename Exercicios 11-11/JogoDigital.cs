using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class JogoDigital:Jogo
    {
         public decimal Tamanho {get;set;}



        public JogoDigital(string?nome, string?plataforma, decimal tamanho) :base(nome, plataforma)
        {
            Tamanho=tamanho;
        }

        public override void ApresentarJogo()
        {
            base.ApresentarJogo();
            Console.WriteLine($"Tamanho GB : {Tamanho}");
        }
    }
}