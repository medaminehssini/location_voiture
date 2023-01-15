using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Matiere
    {
        public int code;
        public string semestre;
        public float cofficient;
        public int crédit;
        public int idmat;
        public int idspecialite;
        public int idenseing;
        List<Note> listNote;
        public int Code { get => code; set => code = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public float Cofficient { get => cofficient; set => cofficient = value; }
        public int Crédit { get => crédit; set => crédit = value; }
        public int IdSpecialite { get => idspecialite; set => idspecialite = value; }
        public int IdMat { get => idmat; set => idmat = value; }
        public int IdEnseing { get => idenseing; set => idenseing = value; }
        internal List<Note> ListNote { get => listNote; set => listNote = value; }

    }
}
