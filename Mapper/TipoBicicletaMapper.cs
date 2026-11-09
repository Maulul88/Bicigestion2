using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TipoBicicletaMapper
    { 
    public static TipoBicicleta Map(SqlDataReader reader)
        {
            TipoBicicleta tipo = new TipoBicicleta();

            tipo.IdTipoBicicleta = Convert.ToInt32(reader["ID_TIPO_BICICLETA"]);
            tipo.Descripcion = reader["DESCRIPCION"].ToString();

            return tipo;
        }
    }
}
