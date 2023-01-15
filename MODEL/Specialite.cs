using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
public  class Specialite
    {
        public string acronyme;
        public int idspecialite;
        List<Matiere> listMatiere;
        public string Acronyme { get => acronyme; set => acronyme = value; }
        public int IdSpecialite { get => idspecialite; set => idspecialite = value; }
      
        internal List<Matiere> ListEtudiant { get => listMatiere; set => listMatiere = value; }
    }
}
