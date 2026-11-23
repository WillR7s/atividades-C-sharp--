using System;
using System.ComponentModel.DataAnnotations; // 1. Importe este namespace

namespace Exercicios23_11.Models
{
    // 2. Herde de ValidationAttribute (e não de Evento)
    public class ValidaDataAttribute : ValidationAttribute
    {
        // 3. Sobrescreva o método IsValid padrão do MVC
        public override bool IsValid(object? value)
        {
            if (value == null) 
                return true; // Deixa o [Required] cuidar se estiver vazio

            DateTime dataInformada = (DateTime)value;

            // Use DateTime.Today (ou DateTime.Now.Date) para não bloquear eventos marcados para hoje
            if (dataInformada.Date < DateTime.Today)
            {
                return false;
            }

            return true;
        }
    }
}