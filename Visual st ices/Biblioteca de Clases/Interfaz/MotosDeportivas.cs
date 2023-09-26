using Biblioteca_de_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MotosDeportivas : Form
    {
        Principal principal = new Principal();
        public MotosDeportivas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Biblioteca_de_Clases.MotoDeportiva motosDeportivas = new Biblioteca_de_Clases.MotoDeportiva();

            motosDeportivas.Id = int.Parse(textid.Text);
            motosDeportivas.Marca = textmarca.Text;
            motosDeportivas.Modelo = textmodelo.Text;
            motosDeportivas.Cilindrada = int.Parse(textcilindrada.Text);   

            principal.AltaMotosDeportivas(motosDeportivas);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.ListamotoDeportivas;

            MessageBox.Show("Guardado ");

            textid.Clear();
            textmarca.Clear();
            textmodelo.Clear();
            textcilindrada.Clear();



        }
        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MotoDeportiva itemSeleccionado = (MotoDeportiva)listBox1.SelectedItem;
            principal.BajaMotosDeportivas(itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.ListamotoDeportivas;
            MessageBox.Show("Eliminado correctamente");



        }
    }
}
