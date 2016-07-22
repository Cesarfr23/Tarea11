using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace RegistroPeliculas
{
    public partial class Categorias : Form
    {
        Categoria categoria = new Categoria();
        public Categorias()
        {
            InitializeComponent();
        }
        private void LlenaClase(Categoria categoria)
        {
            categoria.CategoriaId = 0;
            categoria.Descripcion = DescripcionTextBox.Text;

        }
        private void LlenaCampos(Categoria categoria)
        {
            CategoriasIdTextBox.Text = categoria.CategoriaId.ToString();
            DescripcionTextBox.Text = categoria.Descripcion;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LlenaCampos(CategoriasBll.Buscar(Convert.ToInt32(CategoriasIdTextBox.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriasBll.Insertar(LlenaClase());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LlenarClase(categoria);

            CategoriasBll.Eliminar(StringToInt(CategoriasIdTextBox.Text));
        }
        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LlenarClase(categoria);
        }
    }
}
