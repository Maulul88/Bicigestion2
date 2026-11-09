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
    public class AlquilerDao
    {
        private TipoBicicletaDao tipoBicicletaDao = new TipoBicicletaDao();

        public List<Alquiler> GetAll()
        {
            try
            {
                List<Alquiler> alquileres = new List<Alquiler>();

                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = @"SELECT ID_ALQUILER, ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER FROM ALQUILER";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idTipo = Convert.ToInt32(reader["ID_TIPO_BICICLETA"]);
                                TipoBicicleta tipo = tipoBicicletaDao.GetById(idTipo);

                                alquileres.Add(AlquilerMapper.Map(reader, tipo));
                            }
                        }
                    }
                }

                return alquileres;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Alquiler GetById(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = @"SELECT ID_ALQUILER, ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER FROM ALQUILER WHERE ID_ALQUILER = @ID";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idTipo = Convert.ToInt32(reader["ID_TIPO_BICICLETA"]);
                                TipoBicicleta tipo = tipoBicicletaDao.GetById(idTipo);

                                return AlquilerMapper.Map(reader, tipo);
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
        public void CargarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = @"INSERT INTO ALQUILER
                             (ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER)
                             VALUES
                             (@IdTipoBicicleta, @DniCliente, @ImporteTotal, @FechaRegistro, @FechaAlquiler)";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@IdTipoBicicleta", alquiler.TipoBicicleta.IdTipoBicicleta);
                        command.Parameters.AddWithValue("@DniCliente", alquiler.DniCliente);
                        command.Parameters.AddWithValue("@ImporteTotal", alquiler.ImporteTotal);
                        command.Parameters.AddWithValue("@FechaRegistro", alquiler.FechaRegistro);
                        command.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaAlquiler);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Modificar(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = @"UPDATE ALQUILER
                             SET IMPORTE_TOTAL = @ImporteTotal,
                                 FECHA_ALQUILER = @FechaAlquiler
                             WHERE ID_ALQUILER = @ID";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@ImporteTotal", alquiler.ImporteTotal);
                        command.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaAlquiler);
                        command.Parameters.AddWithValue("@ID", alquiler.IdAlquiler);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Eliminar(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    conexion.Open();

                    string query = "DELETE FROM ALQUILER WHERE ID_ALQUILER = @ID";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@ID", alquiler.IdAlquiler);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
