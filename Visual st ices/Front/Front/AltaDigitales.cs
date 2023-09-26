using LogicaParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class AltaDigitales : Form
    {
        Principal principal = new Principal();
        public AltaDigitales()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ProductoDigital productoDigital = new ProductoDigital();

            productoDigital.codigo = int.Parse(textCodigo2.Text);
            productoDigital.nombre = textNombre2.Text;
            productoDigital.precio = int.Parse(textPrecio2.Text);
            productoDigital.tamañoArchivo = int.Parse(texttamaño.Text);

            principal.AltaPrductosDigitales(productoDigital);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.ListaproductoDigital;

            MessageBox.Show("bien flaco ");

            textCodigo2.Clear();
            textNombre2.Clear();
            textPrecio2.Clear();
            texttamaño.Clear();



        }

        private void textCantidad2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            ProductoDigital itemSeleccionadoD = (ProductoDigital)listBox1.SelectedItem;
            principal.BajaProductoDigitales(itemSeleccionadoD);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.ListaproductoDigital;
            MessageBox.Show("Producto eliminado correctamente");



        }

        private void Volver2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();

        }
    }
}
