using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicios23_11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercicios23_11.Controllers
{
    public class EventosController:Controller
    {
          private static List<Evento> _eventos = new()
        {
            new Evento {Id =1, Nome = "Conferência de Tecnologia", Descricao = "Evento sobre as latest tendências em tecnologia", Local = "Auditório Principal", DataEvento = DateTime.Now.AddDays(7), QuantidadeVagas = 100, ValorIngresso = 50.00m },
            new Evento {Id =2, Nome = "Workshop de Desenvolvimento Web", Descricao = "Aprenda a criar aplicações web modernas", Local = "Sala de Aula 101", DataEvento = DateTime.Now.AddDays(14), QuantidadeVagas = 50, ValorIngresso = 75.00m },
        };
         public IActionResult Index()
        {
            return View(_eventos);
        }
       
       public IActionResult Detalhes(int Id)
        {
            var evento =_eventos.FirstOrDefault(e=> e.Id ==Id);

            if (evento ==null )
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

[HttpPost]
public IActionResult Criar(Evento evento)
        {
            if (!ModelState.IsValid)
            {
                return View(evento);
            }

            evento.Id = _eventos.Any()? _eventos.Max(e=>e.Id)+1:1;
            _eventos.Add(evento);

            return RedirectToAction("Index");
        }

        
        
    }
}