﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class Cliente : Ticket
    {
        int dni;
        static int nroInicio = 0;
        public Cliente(string dni)
        {
            this.dni = Convert.ToInt32(dni);
            nroOrden = ++nroInicio;
            if (this.dni < 3000000 || this.dni > 45000000)
            {
                throw new DNIexcepction();
            }
        
        }
    }
}
