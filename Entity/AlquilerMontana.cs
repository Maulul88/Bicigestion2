using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AlquilerMontana : Alquiler
    {
        public override string ObtenerTipoBicicleta()
        {
            return "Montaña";
        }
    }
}
