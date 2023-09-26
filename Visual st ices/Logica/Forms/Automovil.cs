using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Automovil : Form
    {
        Principal principal = new Principal();
        public Automovil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehiculoAutomovil vehiculoAutomovil = new VehiculoAutomovil();  

            vehiculoAutomovil.patente = textPatente.Text;
            vehiculoAutomovil.marca = textMarca.Text;
            vehiculoAutomovil.modelo = textModelo.Text;
            vehiculoAutomovil.PrecioDia = decimal.Parse(textPrecio.Text);
            vehiculoAutomovil.NdePuertas = int.Parse(textNroPuertas.Text);
            vehiculoAutomovil.NdeAsientos = int.Parse(textNroAsientos.Text);
            
            principal.AltaVehiculoAutomovil(vehiculoAutomovil);

            listBox1.DataSource = null; 
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.ListaVehiculoAutomovil;

            MessageBox.Show("Vehiculo Guardado ");

            textPatente.Clear();    
            textModelo.Clear();
            textMarca.Clear();
            textPrecio.Clear(); 
            textNroPuertas.Clear(); 
            textNroAsientos.Clear();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            VehiculoAutomovil itemseleccionado = (VehiculoAutomovil)listBox1.SelectedItem;

            principal.BajaVehiculoAutomovil(itemseleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.ListaVehiculoAutomovil;
            MessageBox.Show(" Eliminado ");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();  
            this.Close();   
        }
    }
}
