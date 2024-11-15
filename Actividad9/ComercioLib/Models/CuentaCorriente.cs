using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class CuentaCorriente : IComparable<CuentaCorriente>
    {
        Cliente titular;
        int nroCuenta;

        public CuentaCorriente(int nroCC, Cliente cliente)
        {
            titular = cliente;
            nroCuenta = nroCC;
        }

        public int CompareTo(CuentaCorriente? cc)
        {
            return cc != null ? nroCuenta.CompareTo(cc.nroCuenta) : -1;
        }
    }
}
