using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    class PeliculasDb : DbContext
    {
        public PeliculasDb() : base("name = Peliculas")
        {

        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Pelicula> Pelicula { get; set; }
    }
}
