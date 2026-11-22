using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public abstract class Jogo
    {
        public string? Nome {get;set;}
         protected string? Plataforma;

         public Jogo(string? nome, string? plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }


         public virtual void ApresentarJogo()
        {
            Console.WriteLine ($"Nome:{Nome}");
            Console.WriteLine ($"Plataforma:{Plataforma}");
        }
    }
}