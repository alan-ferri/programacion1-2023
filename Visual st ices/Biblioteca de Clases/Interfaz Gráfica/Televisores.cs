using Biblioteca_Ejercicio_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsElectronica
{
    public partial class Televisores : Form
    {
        Principal principal = new Principal();
        public Televisores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Televisor tele_nuevo = new Televisor(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            principal.AgregarTelevisor(tele_nuevo);
            MessageBox.Show("Se agrego el tele");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.televisores;
        }

        private void Televisores_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            principal.EliminarTelevisor((Televisor)listBox1.SelectedItem);
            MessageBox.Show("Eliminado correctamente");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.televisores;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Televisor reemplazo = new Televisor(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            principal.ModificarTelevisor((Televisor)listBox1.SelectedItem, reemplazo);
            MessageBox.Show("Se realizo realizada");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.televisores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
    }

