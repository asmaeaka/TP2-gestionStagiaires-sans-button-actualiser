using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PackageStagiaires{
    public partial class FormStagiaire : Form
    {
        public FormStagiaire()
        {
            InitializeComponent();
        }

        private FormGestionStagiaires formulaireGestionStagiaires;
        public FormGestionStagiaires FormulaireGestionStagiaires
        {
            get { return formulaireGestionStagiaires; }
            set { formulaireGestionStagiaires = value; }
        }

        private void BtEnregistrer_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.Id =  Convert.ToInt32(txtId.Text) ;
            s.Nom = txtNom.Text;
            s.Prenom = txtPrenom.Text;
            GestionStagiaires g = new GestionStagiaires();
            g.Ajouter(s);
            this.Hide();

            formulaireGestionStagiaires.actualiser();
        }

        private void FormStagiaire_Load(object sender, EventArgs e)
        {

        }
    }
}
