using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackageStagiaires{
    public class Stagiaire{
        int id;
        String nom;
        String prenom;

        public Stagiaire(int id, String nom, String prenom) {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Stagiaire()
        {
        }
        public int Id{
            get { return id; }
            set { id = value; }
        } 
        public String Nom{
            get { return nom; }
            set { nom = value; }
        }
        public String Prenom{
            get { return prenom; }
            set { prenom = value; }
        }
    }
}
