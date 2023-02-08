using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caminho_Minimo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CaminhoMínimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo formgrafo = new frmGrafo();
            formgrafo.Show();
            formgrafo = null;
        }

        private void CidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
