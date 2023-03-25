using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDC_PDV
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFuncionario_Click(object sender, EventArgs e)
        {
            cadastro.frmFuncionarios frm = new cadastro.frmFuncionarios();
            frm.ShowDialog();
        }
    }
}
