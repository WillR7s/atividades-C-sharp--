using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class NotificacaoPush:Notificacao
    {


        public NotificacaoPush(string?mensagem):base(mensagem)
        {
            
        }

        public override void Enviar()
        {
             Console.WriteLine($"Notificação via push: {Mensagem}");
            Console.WriteLine("Enviado com sucesso!");
        }    
    }
}