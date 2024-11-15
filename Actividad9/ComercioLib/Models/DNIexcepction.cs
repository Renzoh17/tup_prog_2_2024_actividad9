using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    internal class DNIexcepction : ApplicationException
    {
        public DNIexcepction():base("Formato DNI incorrecto") { }
        public DNIexcepction(string message) : base(message) { }
        public DNIexcepction(string msg, Exception inner):base(msg, inner) { }
    }
}
