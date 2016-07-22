using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class CategoriasBll
    {
        public static bool Insertar(Categoria categoria)
        {
            bool retorno = false;
            try
            {
                using (var db = new PeliculasDb())
                {
                    db.Categoria.Add(categoria);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public static Categoria Buscar(int CategoriaId)
        {
            var db = new PeliculasDb();

            return db.Categoria.Find(CategoriaId);
        }

        public static void Eliminar(int IdCate)
        {
            var db = new PeliculasDb();

            Categoria categoria = (from cate in db.Categoria
                                 where cate.CategoriaId == IdCate
                                 select cate).FirstOrDefault();
            db.Categoria.Remove(categoria);
            db.SaveChanges();
        }

        public static Categoria Modificar(int IdCate)
        {
            var db = new PeliculasDb();

            Categoria categoria = (from cate in db.Categoria
                                 where cate.CategoriaId == IdCate
                                 select cate).FirstOrDefault();
            return categoria;
        }

        public static List<Categoria> GetLista()
        {
            List<Categoria> lista = new List<Categoria>();

            var db = new PeliculasDb();

            lista = db.Categoria.ToList();

            return lista;

        }
    }
}
