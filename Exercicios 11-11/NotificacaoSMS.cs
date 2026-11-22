using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class NotificacaoSMS:Notificacao
    {
        


public NotificacaoSMS(string?mensagem):base(mensagem)
        {
            
        }
        public override void Enviar()
        {
             Console.WriteLine($"Notificação via SMS: {Mensagem}");
            Console.WriteLine("Enviado com sucesso!");
        }


    }
}