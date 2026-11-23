using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Exercicios23_11.Models
{
    public class Evento
    {
        public int Id {get;set;}

        [Required (ErrorMessage ="Nome é Obrigatório.")]
        [StringLength(80,MinimumLength =5)]
        public string? Nome{get;set;}

        
        [Required (ErrorMessage ="Descrição é Obrigatório.")]
        [StringLength(100,MinimumLength =10)]
        public string? Descricao {get;set;}

          [Required (ErrorMessage ="Local é Obrigatório.")]
        [StringLength(100,MinimumLength =3)]
        public string? Local{get;set;}

        [Required (ErrorMessage ="Data do Evento é Obrigatória.")]
        [ValidaData(ErrorMessage = "A data não pode ser anterior à data atual.")]
        [DataType(DataType.Date)]
        public DateTime DataEvento{get;set;}

        [Range(1, 1000, ErrorMessage = "A capacidade deve ser entre 1 e 1000.")]
        public int QuantidadeVagas {get;set;}

        [Range(0, double.MaxValue, ErrorMessage = "O valor do ingresso deve ser maior ou igual a zero.")]
        public decimal ValorIngresso{get;set;}
    }
}