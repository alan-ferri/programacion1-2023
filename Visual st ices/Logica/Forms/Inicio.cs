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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Camioneta camioneta = new Camioneta();
            camioneta.Show();   
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Automovil automovil = new Automovil();  
            automovil.Show();   
            this.Hide();
        }
    }
}
