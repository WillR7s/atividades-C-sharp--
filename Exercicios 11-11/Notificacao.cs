using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class Notificacao
    {
        public string? Mensagem {get;set;}



        public Notificacao (string?mensagem)
        {
            Mensagem=mensagem;
        }

        public virtual void Enviar()
        {
            Console.WriteLine("Escolha um o Canal antes de enviar a mensagem.");
        }
    }
}