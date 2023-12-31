using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[] {
        new Evento() {
            EventoId = 1,
            Tema = "Angular e Dot net Core",
            Local = "Belo Horizonte",
            Lote = "1 - primeiro Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.img"
        },
        new Evento(){
            EventoId = 2,
            Tema = "Angular e Novidasdes",
            Local = "sao paulo",
            Lote = "2 - primeiro Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto2.img"
        }
    };


    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento=>evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id {id}";
    }


}
