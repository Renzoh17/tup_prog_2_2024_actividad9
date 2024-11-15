using ComercioLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.DTO
{
    public class TicketDTO
    {
        public int nroOrden { get; set; }
        public DateTime fechaHora {  get; set; }
        public int tipoTicket { get; set; }

        public TicketDTO(Ticket t) 
        {
            nroOrden = t.VerNroOrden();
            fechaHora = t.VerFechaHora();
            if (t is Cliente)
            {
                tipoTicket = 1;
            }
            else if (t is Pago) 
            {
                tipoTicket = 2;
            }
        }
    }
}
