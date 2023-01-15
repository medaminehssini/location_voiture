using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Enseignant
    {
        public string nom;
        public string prenom;
        public string login;
        public DateTime datenaiss;
        public string password;
        public string lieu;
        public string email;
        public int idenseing;
        List<Matiere> listMatiere;
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime Datenaiss { get => datenaiss; set => datenaiss = value; }
        public string Lieu { get => lieu; set => lieu = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Idenseing { get => idenseing; set => idenseing = value; }
        internal List<Matiere> ListEtudiant { get => listMatiere; set => listMatiere = value; }

    }
}
