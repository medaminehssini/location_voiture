using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Etudiant
    {
        public string nom;
        public string prenom;
        public string login;
        public DateTime datenaiss;
        public string password;
        public int idetud;
        public int idgroupe;
        List<Note> listNote;
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime Datenaiss { get => datenaiss; set => datenaiss = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int IdEtud { get => idetud; set => idetud = value; }
        public int IdGroupe { get => idgroupe; set => idgroupe = value; }
        internal List<Note> ListNote { get => listNote; set => listNote = value; }

    }
}
