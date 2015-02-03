using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupAssist
{
    public partial class FormAccueil : Form
    {
        public FormAccueil(string Str_Value)
        {
            InitializeComponent();
            labelConnecte.Text = "Connecté en tant que : " + Str_Value;
        }

        private void FormAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous vraiment fermer l'application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNouveauClient FormClient = new FormNouveauClient();
            FormClient.ShowDialog(this);
        }
    }
}
