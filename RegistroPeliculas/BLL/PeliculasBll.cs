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

        public static Pelicula Buscar(int PeliculasId)
        {
            var db = new PeliculasDb();

            return db.Pelicula.Find(PeliculasId);
        }

        public static void Eliminar(int IdPelis)
        {
            var db = new PeliculasDb();

            Pelicula pelicula = (from pelis in db.Pelicula
                              where pelis.PeliculasId == IdPelis
                              select pelis).FirstOrDefault();
            db.Pelicula.Remove(pelicula);
            db.SaveChanges();  
        }

        public static Pelicula Modificar(int IdPelis)
        {
            var db = new PeliculasDb();

            Pelicula pelicula = (from pelis in db.Pelicula
                                 where pelis.PeliculasId == IdPelis
                                 select pelis).FirstOrDefault();
            return pelicula;
        }
    }

   
}
