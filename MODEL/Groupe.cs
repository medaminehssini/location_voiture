using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Groupe
    {
      
        int idgroupe;
        string nom;
        List<Etudiant> listEtudiant;

      
        
        
        public int Idgroupe { get => idgroupe; set => idgroupe = value; }
        public string Nom { get => nom; set => nom = value; }
        internal List<Etudiant> ListEtudiant { get => listEtudiant; set => listEtudiant = value; }
    }
}
