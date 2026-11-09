using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoBicicletaBusiness
    {
        private TipoBicicletaDao tipoBicicletaDao = new TipoBicicletaDao();

        public List<TipoBicicleta> GetAll()
        {
            try
            {
                return tipoBicicletaDao.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
