using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Alquiler
    {
        public int IdAlquiler { get; set; }
        public TipoBicicleta TipoBicicleta { get; set; }
        public string DniCliente { get; set; }
        public decimal ImporteTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaAlquiler { get; set; }

        public abstract string ObtenerTipoBicicleta();
    }
}
