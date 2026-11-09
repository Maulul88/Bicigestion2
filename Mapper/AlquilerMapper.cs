using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class AlquilerMapper
    {
        public static Alquiler Map(SqlDataReader reader, TipoBicicleta tipo)
        {
            Alquiler alquiler;

            if (tipo.Descripcion == "Urbana")
            {
                alquiler = new AlquilerUrbana();
            }
            else if (tipo.Descripcion == "Montaña")
            {
                alquiler = new AlquilerMontana();
            }
            else
            {
                alquiler = new AlquilerElectrica();
            }

            alquiler.IdAlquiler = Convert.ToInt32(reader["ID_ALQUILER"]);
            alquiler.TipoBicicleta = tipo;
            alquiler.DniCliente = reader["DNI_CLIENTE"].ToString();
            alquiler.ImporteTotal = Convert.ToDecimal(reader["IMPORTE_TOTAL"]);
            alquiler.FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"]);
            alquiler.FechaAlquiler = Convert.ToDateTime(reader["FECHA_ALQUILER"]);

            return alquiler;
        }
    }
}
