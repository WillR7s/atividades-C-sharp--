using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_11_11
{
    public class NotificacaoEmail:Notificacao
    {
    
    
    public NotificacaoEmail(string?mensagem):base(mensagem)
        {
            
        }

        public override void Enviar()
        {
            Console.WriteLine($"Notificação via Email: {Mensagem}");
            Console.WriteLine("Enviado com sucesso!");
        }
    }
}