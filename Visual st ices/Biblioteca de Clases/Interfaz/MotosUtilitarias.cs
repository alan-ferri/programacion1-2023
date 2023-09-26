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
using static System.Net.Mime.MediaTypeNames;

namespace Interfaz
{
    public partial class MotosUtilitarias : Form
    {
        Principal principal = new Principal();
        public MotosUtilitarias()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Biblioteca_de_Clases.MotoUtilitaria motoUtilitaria = new Biblioteca_de_Clases.MotoUtilitaria();

            motoUtilitaria.Id = int.Parse(textid2.Text);
            motoUtilitaria.Marca = textmarca2.Text;
            motoUtilitaria.Modelo = textmodelo2.Text;
            motoUtilitaria.Uso = textuso.Text;

            principal.AltaMotosUtilitaria(motoUtilitaria);  

            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.ListamotosUtilitarias;

            MessageBox.Show("Guardado ");

            textid2.Clear();
            textmarca2.Clear();
            textmodelo2.Clear();
            textuso.Clear();



        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            {
                MotoUtilitaria itemSeleccionado = (MotoUtilitaria)listBox1.SelectedItem;
                principal.BajaMotosUtilitaria(itemSeleccionado);
                listBox1.DataSource = null;
                listBox1.DisplayMember = "Name";
                listBox1.DataSource = principal.ListamotoDeportivas;
                MessageBox.Show("Eliminado correctamente");



            }
        }
    }
    }

