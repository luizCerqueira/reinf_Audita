using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REINF
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarregar carrega = new FrmCarregar();
            this.Visible = false;
            carrega.ShowDialog();
            this.Visible = true;
        }
    }
}
