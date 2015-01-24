using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PackageStagiaires;

namespace AppStagiaire.PackageStagiaires{
    public partial class FormUpdateStagiaire : Form
    {
        public FormUpdateStagiaire(){
            InitializeComponent();
    }
        private FormGestionStagiaires formulaireGestionStagiaires;
        public FormGestionStagiaires FormulaireGestionStagiaires
        {
            get {return formulaireGestionStagiaires;}
            set {formulaireGestionStagiaires = value;}
        }
        public void Update (int index)
        {
            Stagiaire s = new GestionStagiaires().getStagiaire(index);
            lbl_id.Text = s.Id + "";
            txtNom.Text = s.Nom;
            txtPrenom.Text = s.Prenom;
        }

        private void FormUpdateStagiaire_Load(object sender,EventArgs e)
        {
        }
        private void btUpdate_Click(object sender,EventArgs e)
        {
            Stagiaire s =new Stagiaire();
            s.Id = Convert.ToInt32(lbl_id.Text);
            s.Nom = txtNom.Text;
            s.Prenom = txtPrenom.Text;
            new GestionStagiaires().Modifier(s);
    }
    }
}
