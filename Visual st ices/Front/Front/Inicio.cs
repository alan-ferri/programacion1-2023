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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaTangibles alta = new AltaTangibles();
            alta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaDigitales altaDigitales = new AltaDigitales();  
            altaDigitales.Show();   
            this.Hide();    
        }
    }
}
