using ComercioLib.DTO;
using ComercioLib.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationServicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComercioController : ControllerBase
    {
        Comercio comercio = new Comercio();
        // GET: api/<ComercioController>
        [HttpGet("AgregarTicket")]
        public IActionResult Get(int tipo, string dni, int nroCC)
        {
            Ticket t = null;
            if (tipo == 1)
            {
                t = new Cliente(dni);
            }
            else if(tipo == 2)
            {
                CuentaCorriente cc = comercio.VerCC(nroCC);
                t = new Pago(cc);
            }
            if (t != null)
            {
                comercio.AgregarTicket(t);
                return Ok("Ticket agregado");
            }
            return NotFound("Ticket no generado");            
        }
        [HttpGet("AtenderTicket")]
        public IActionResult GetAtenderTicket(int tipo)
        {
            TicketDTO td = null;
            Ticket t = comercio.AtenderTicket(tipo);
            if (t != null)
            {
                td = new TicketDTO(t);
                return Ok(td);
            }
            return NotFound("NO HAY TICKET");
        }
        [HttpGet("AgregarCuenta")]
        public IActionResult GetAgregarCC(int nroCC, string dni)
        {
            CuentaCorriente cc = comercio.AgregarCC(nroCC, dni);
            return Ok(cc);
        }
    }
}
