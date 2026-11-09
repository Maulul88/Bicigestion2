using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AlquilerUrbana : Alquiler
    {
        public override string ObtenerTipoBicicleta()
        {
            return "Urbana";
        }
    }
}
