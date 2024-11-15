using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models;

public class Comercio
{
    List<CuentaCorriente> cuentas = new List<CuentaCorriente>();
    Queue<Cliente> nuevosClientes = new Queue<Cliente>();
    Queue<Pago> nuevosP = new Queue<Pago>();
    List<Ticket> listaAtendidos = new List<Ticket>();
    public Ticket AgregarTicket(Ticket t)
    {
        if (t is Cliente c)
        {
            nuevosClientes.Enqueue(c);
        }
        else if(t is Pago p)
        {
            nuevosP.Enqueue(p);
        }
        return null;
    }
    public CuentaCorriente VerCC(int nro)
    {
        CuentaCorriente cc = new CuentaCorriente(nro, new Cliente("5000000"));
        cuentas.Sort();
        int idx = cuentas.BinarySearch(cc);
        return idx >= 0 ? cuentas[idx] : null;
    }

    public Ticket AtenderTicket(int tipo)
    {
        Ticket t = null;
        if (tipo == 2)
        {
            if(nuevosP.Count > 0)
                t = nuevosP.Dequeue();
        }
        else if(tipo == 1)
        {
            if(nuevosClientes.Count > 0)
                t = nuevosClientes.Dequeue();
        }
        if (t != null)
        {
            listaAtendidos.Add(t);
        }
        return t;
    }
    public CuentaCorriente AgregarCC(int nro, string dni)
    {
        CuentaCorriente cc = VerCC(nro);
        if (cc == null)
        {
            Cliente c = new Cliente(dni);
            cc = new CuentaCorriente(nro, c);
        }
        cuentas.Add(cc);
        return cc;
        
    }
}
