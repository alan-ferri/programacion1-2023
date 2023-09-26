using LogicaParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class AltaTangibles : Form
    {
        Principal principal = new Principal();
        public AltaTangibles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoTangible productoTangible = new ProductoTangible(); 

            productoTangible.codigo = int.Parse(textCodigo.Text);  
            productoTangible.nombre = textNombre.Text;  
            productoTangible.precio = int.Parse(textPrecio.Text);
            productoTangible.cantidadStock = int.Parse(textCantidad.Text);

            principal.AltaPrductosTangibles(productoTangible);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.Listaproductostangibles;

            MessageBox.Show("Producto guardado correctamente");

            textCodigo.Clear();
            textNombre.Clear();
            textPrecio.Clear();
            textCantidad.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoTangible itemSeleccionado = (ProductoTangible)listBox1.SelectedItem;
            principal.BajaProductoTangible(itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = principal.Listaproductostangibles;
            MessageBox.Show("Producto eliminado correctamente");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
