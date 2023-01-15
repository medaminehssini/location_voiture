using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER
{
   public class GroupeADO
    {
        public List<Groupe> groupeADOList;
        Connection cnx = new Connection();


        public void load()
        {
            groupeADOList = new List<Groupe>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM Groupe");
            while (reader.Read())
            {


                Groupe groupe = new Groupe();
                groupe.Idgroupe = (int)reader.GetValue(0);
                groupe.Nom = (string)reader.GetValue(1);



                groupeADOList.Add(groupe);


            }
            reader.Close();
        }

        public void insert(Groupe groupe)
        {


            SqlCommand cmd = new SqlCommand("insert into groupe (idgroupe, nom) values ('" + groupe.Idgroupe + "', '" + groupe.Nom + "')");
            cnx.executeCommand(cmd);

        }
        public void update(Groupe groupe)
        {


            SqlCommand cmd = new SqlCommand("update  groupe set idgroupe ='" + groupe.Idgroupe + "' ,  nom =  '" + groupe.Nom + "'; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Groupe groupe)
        {

            SqlCommand cmd = new SqlCommand("delete from  groupe  where idgroupe = " + groupe.Idgroupe + "; ");
            cnx.executeCommand(cmd);
        }

    }
}
