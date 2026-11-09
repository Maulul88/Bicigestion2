using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoBicicletaDao
    {
        public List<TipoBicicleta> GetAll()
        {
            try
            {
                List<TipoBicicleta> tipos = new List<TipoBicicleta>();

                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = "SELECT ID_TIPO_BICICLETA, DESCRIPCION FROM TIPO_BICICLETA";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tipos.Add(TipoBicicletaMapper.Map(reader));
                            }
                        }
                    }
                }

                return tipos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TipoBicicleta GetById(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = "SELECT ID_TIPO_BICICLETA, DESCRIPCION FROM TIPO_BICICLETA WHERE ID_TIPO_BICICLETA = @ID";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return TipoBicicletaMapper.Map(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
