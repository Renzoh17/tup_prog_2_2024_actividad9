using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public abstract class Ticket
    {
        protected int nroOrden;
        DateTime fechaHora;

        public int VerNroOrden()
        {
            return nroOrden;
        }
        public DateTime VerFechaHora()
        {
            return fechaHora;
        }
    }
}
