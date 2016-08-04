using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Natillera.Models
{
    public class ControlPagos
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Valor { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}