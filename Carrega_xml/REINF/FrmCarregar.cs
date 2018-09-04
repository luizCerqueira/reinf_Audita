using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REINF
{
    public partial class FrmCarregar : Form
    {
        bool verificar = false;
        string[] arquivos;

        public FrmCarregar()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (verificar)
            {
                foreach (var item in arquivos)
                {

                }
            }
            else
            {
                MessageBox.Show("Erro na verificação ou XMLs estão incorretos","Erros",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtCaminho.Text))
            {
                arquivos = Directory.GetFiles(txtCaminho.Text,"*.XML");
                FileInfo infoArquivo;

                foreach (string arq in arquivos)
                {
                    infoArquivo = new FileInfo(arq);
                    lblCarregarXmls.Text += string.Format("Nome: {0}", infoArquivo.Name + "\n");

                    if (infoArquivo.Name.Trim().Replace("-", "").Contains("R1000"))
                    {
                        verificar = true;
                    }
                }
                btnVerifica.Enabled = false;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCaminho.Clear();
            lblCarregarXmls.Clear();
            btnVerifica.Enabled = true;
            verificar = false;
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text =  dlg.SelectedPath;
            }
        }
    }
}
