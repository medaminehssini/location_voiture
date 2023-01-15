using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    internal class Ligne_cmd
    {
        private int qte, id_cmd, id_article;

        public int Qte { get => qte; set => qte = value; }
        public int Id_cmd { get => id_cmd; set => id_cmd = value; }
        public int Id_article { get => id_article; set => id_article = value; }
    }
}
