using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace RegistroPeliculas
{
    public partial class RegistroPelicula : Form
    {
        Pelicula pelicula = new Pelicula();
        public RegistroPelicula()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LlenarClase(pelicula);

            PeliculasBll.Insertar(pelicula);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LlenarClase(pelicula);

            PeliculasBll.Eliminar(StringToInt(PeliculasIdTextBox.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenaCampos(PeliculasBll.Buscar(StringToInt(PeliculasIdTextBox.Text)));
        }
        private void LlenaCampos(Pelicula pelicula)
        {
            PeliculasIdTextBox.Text = pelicula.PeliculasId.ToString();
            TituloTextBox.Text = pelicula.Titulo;
            SignosisTextBox.Text = pelicula.Signosis;
            CalificacionTextBox.Text = pelicula.Calificacion.ToString();
            AnnoComboBox.Text = pelicula.Anno.ToString();
            IdiomaTextBox.Text = pelicula.Idioma;
            GeneroTextBox.Text = pelicula.Genero;
            CategoriaIdComboBox.Text = pelicula.CategoriaId.ToString();
        }

        private void LlenarClase(Pelicula pelicula)
        {
            pelicula.PeliculasId = StringToInt(PeliculasIdTextBox.Text);
            pelicula.Titulo = TituloTextBox.Text;
            pelicula.Signosis = SignosisTextBox.Text;
            pelicula.Calificacion = StringToInt(CalificacionTextBox.Text);
            pelicula.Anno = StringToInt(AnnoComboBox.Text);
            pelicula.Idioma = IdiomaTextBox.Text;
            pelicula.Genero = GeneroTextBox.Text;
            pelicula.CategoriaId = (int)CategoriaIdComboBox.SelectedValue;
        }
        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LlenarClase(pelicula);

           LlenaCampos(PeliculasBll.Modificar(StringToInt(PeliculasIdTextBox.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarClase(pelicula);
        }
    }
}
