using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AlquilerElectrica : Alquiler
    {
        public override string ObtenerTipoBicicleta()
        {
            return "Eléctrica";
        }
    }
}
