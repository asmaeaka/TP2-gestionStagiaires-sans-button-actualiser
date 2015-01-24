using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PackageStagiaires;

namespace AppStagiaire
{
    public partial class MenuApplication : Form
    {
        public MenuApplication()
        {
            InitializeComponent();
        }

        private void gestionDesStagiairesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGestionStagiaires f = new FormGestionStagiaires();
            f.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
