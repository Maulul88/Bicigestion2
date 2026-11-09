using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class AlquilerBusiness
    {
        private AlquilerDao alquilerDao = new AlquilerDao();
        private TipoBicicletaDao tipoBicicletaDao = new TipoBicicletaDao();

        public List<Alquiler> GetAll()
        {
            try
            {
                return alquilerDao.GetAll();
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
                if (id <= 0)
                {
                    throw new Exception("El ID debe ser mayor a cero.");
                }

                return alquilerDao.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ValidarAlquiler(Alquiler alquiler)
        {
            if (alquiler == null)
            {
                throw new Exception("El alquiler no puede ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(alquiler.DniCliente))
            {
                throw new Exception("El DNI no puede estar vacío.");
            }

            if (alquiler.DniCliente.Length <= 5)
            {
                throw new Exception("El DNI debe tener más de 5 caracteres.");
            }

            if (alquiler.TipoBicicleta == null)
            {
                throw new Exception("Debe seleccionar un tipo de bicicleta.");
            }

            TipoBicicleta tipoExistente = tipoBicicletaDao.GetById(alquiler.TipoBicicleta.IdTipoBicicleta);

            if (tipoExistente == null)
            {
                throw new Exception("El tipo de bicicleta no existe en la base de datos.");
            }

            if (alquiler.ImporteTotal <= 0)
            {
                throw new Exception("El importe total debe ser mayor a cero.");
            }

            if (alquiler.FechaAlquiler.Date < DateTime.Now.Date)
            {
                throw new Exception("La fecha del alquiler no puede ser menor a la fecha actual.");
            }
        }
        public void CargarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ValidarAlquiler(alquiler);

                    alquiler.FechaRegistro = DateTime.Now;

                    alquilerDao.CargarAlquiler(alquiler);

                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CargarMultiplesAlquileres(List<Alquiler> alquileres)
        {
            try
            {
                if (alquileres == null || alquileres.Count == 0)
                {
                    throw new Exception("No hay alquileres para guardar.");
                }

                using (var trx = new TransactionScope())
                {
                    foreach (Alquiler alquiler in alquileres)
                    {
                        CargarAlquiler(alquiler);
                    }

                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Modificar(int idAlquiler, decimal nuevoImporte, DateTime nuevaFecha)
        {
            try
            {
                Alquiler alquilerFromDb = GetById(idAlquiler);

                using (var trx = new TransactionScope())
                {
                    if (alquilerFromDb == null)
                    {
                        throw new Exception("No existe el alquiler solicitado.");
                    }

                    if (nuevoImporte <= 0)
                    {
                        throw new Exception("El importe total debe ser mayor a cero.");
                    }

                    if (nuevaFecha.Date < DateTime.Now.Date)
                    {
                        throw new Exception("La fecha del alquiler no puede ser menor a la fecha actual.");
                    }

                    alquilerFromDb.ImporteTotal = nuevoImporte;
                    alquilerFromDb.FechaAlquiler = nuevaFecha;

                    alquilerDao.Modificar(alquilerFromDb);

                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Eliminar(int idAlquiler)
        {
            try
            {
                Alquiler alquilerFromDb = GetById(idAlquiler);

                using (var trx = new TransactionScope())
                {
                    if (alquilerFromDb == null)
                    {
                        throw new Exception("No existe el alquiler solicitado.");
                    }

                    alquilerDao.Eliminar(alquilerFromDb);

                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
