using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pelicula
    {
        [Key]
        public int PeliculasId { get; set; }
        public string Titulo { get; set; }
        public string Signosis { get; set; }
        public int Calificacion { get; set; }
        public int Anno { get; set; }
        public string Idioma { get; set; }
        public string Genero { get; set; }
        public int CategoriaId { get; set; }

        public Pelicula()
        {

        }

        public Pelicula(int PeliculasId, string Titulo, string Signosis, int Calificacion, int Anno, string Idioma, string Genero, int CategoriaId)
        {
            this.PeliculasId = PeliculasId;
            this.Titulo = Titulo;
            this.Signosis = Signosis;
            this.Calificacion = Calificacion;
            this.Anno = Anno;
            this.Idioma = Idioma;
            this.Genero = Genero;
            this.CategoriaId = CategoriaId;
        }
    }


}
