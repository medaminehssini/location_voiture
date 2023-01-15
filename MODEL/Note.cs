using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Note
    {
     
        public float td;
        public float tp;
        public float examen;

        public int idmat;
        public int idnote;
        public int idetud;
        
        public int  IdNote { get => idnote; set => idnote = value; }
      
        public float Examen { get => examen; set => examen = value; }
        public float Td { get => td; set => td = value; }
        public float Tp { get => tp; set => tp = value; }
        public int IdMat { get => idmat; set => idmat = value; }
        public int IdEtud{ get => idetud; set => idetud = value; }
    

    }
}
