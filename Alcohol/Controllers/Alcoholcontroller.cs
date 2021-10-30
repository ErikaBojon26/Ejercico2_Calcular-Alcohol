using Alcohol.Domain.entities;
using Microsoft.AspNetCore.Mvc;

namespace Alcohol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Alcoholcontroller : ControllerBase
    {
        [HttpGet]
        [Route("Calcular")]
        
        public IActionResult Calculame(string Bebida,int cantidadAlcohol, int pesopersona)
        {
            
            var result = new Cantidad();
            result.TotaldeAlcohol(Bebida,cantidadAlcohol);
            if(Bebida.ToLower()!= "cerveza"  && Bebida.ToLower()!="licor" && Bebida.ToLower()!="vermu"&& Bebida.ToLower()!="cava"  && Bebida.ToLower()!="brandy"&& Bebida.ToLower()!="vino")
            {
                return Ok("La bebida es incorecta, intente de nuevo :) .");
            }
            result.Pesoper(pesopersona);
            
            return Ok(result.Result());
        }
    }
}