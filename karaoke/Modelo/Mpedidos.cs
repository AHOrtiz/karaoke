using System;
using System.Collections.Generic;
using System.Text;

namespace karaoke.Modelo
{
     public class Mpedidos
    {
        public int IdPedido { get; set; }
        public int idMesa { get; set; }
        public int idCancion { get; set; }
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }
}
