using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descricion { get; set; }

        public Categoria()
        {

        }

        public Categoria(int CategoriaId, string Descripcion)
        {
            this.CategoriaId = CategoriaId;
            this.Descricion = Descripcion;

        }
    }
}
