using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class JogoFisico:Jogo
    {
        public string?TipoMidia {get;set;}


        public JogoFisico(string?nome, string?plataforma, string?tipomidia) :base(nome,plataforma)
        {
            TipoMidia=tipomidia;
        }

         public override void ApresentarJogo()
        {
            base.ApresentarJogo();
            Console.WriteLine($"Tipo de Mídia : {TipoMidia}");
        }
    }
    }
