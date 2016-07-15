using Entidades;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PeliculasBll
    {
        public static bool Insertar(Pelicula pelicula)
        {
            bool retorno = false;
            try
            {
                using (var db = new PeliculasDb())
                {
                    db.Pelicula.Add(pelicula);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
    }
}
