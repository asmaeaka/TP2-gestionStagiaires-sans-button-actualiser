using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackageStagiaires
{
    public class GestionStagiaires
    {
       private static List<Stagiaire> listeStagiaires = new List<Stagiaire>();

       static GestionStagiaires() { 
           listeStagiaires.Add(new Stagiaire(1,"Madani","Ali"));
           listeStagiaires.Add(new Stagiaire(2,"Madani","Karim"));
           listeStagiaires.Add(new Stagiaire(3, "Wahabi", "Mouna"));
       }

       public void Ajouter(Stagiaire s)
       {
               listeStagiaires.Add(s);
       }

       public void Supprimer(int index)
       {
           listeStagiaires.RemoveAt(index);
       }

       public void Modifier(Stagiaire s) {
           foreach (Stagiaire item in listeStagiaires)
           {
               if (item.Id == s.Id) {
                   item.Nom = s.Nom;
                   item.Prenom = s.Prenom;
               }
           }
       }

       public List<Stagiaire> Afficher()
       {
           return listeStagiaires;
       }

       public Stagiaire getStagiaire(int index)
       {
            return listeStagiaires.ElementAt(index);
       }
    }
}
