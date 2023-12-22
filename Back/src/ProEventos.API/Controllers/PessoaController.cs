using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PessoaController : ControllerBase
{

 [HttpGet]
    public string Get()
    {
        return "Deutslshncd";
    }

}