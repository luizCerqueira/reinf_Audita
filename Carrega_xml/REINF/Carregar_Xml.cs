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
    public partial class Carregar_Xml : Form
    {

        public Carregar_Xml(string[] arquivos)
        {
            InitializeComponent();
            carregar_Xmls_database(arquivos);
        }

        protected static void carregar_Xmls_database(string[] arq)
        {

        }
    }
}
