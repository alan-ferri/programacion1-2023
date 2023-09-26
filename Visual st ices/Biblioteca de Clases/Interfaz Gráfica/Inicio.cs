using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsElectronica
{
    public partial class MenuPrincipal : Form
    {
        Televisores televisores = new Televisores();
        Smartphones smartphones = new Smartphones();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTele_Click(object sender, EventArgs e, Televisores televisores)
        {
            Televisores televisores1 = new Televisores();
            televisores.Show();
            this.Close();   
        }

        private void btnSmart_Click(object sender, EventArgs e, Smartphones smartphones)
        {
            Smartphones smartphones1 = new Smartphones();
            smartphones1.Show();
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
