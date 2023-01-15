using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MODEL;

    namespace CONTROLLER { 
    
        public class MatiereADO
        {

            public List<Matiere> MatiereADOList;
            Connection cnx = new Connection();


            public void load()
            {
                MatiereADOList = new List<Matiere>();
                SqlDataReader reader = cnx.SDD("SELECT * FROM Matiere");
                while (reader.Read())
                {


                    Matiere matiere = new Matiere();
                    matiere.idmat = (int)reader.GetValue(0);
                    matiere.code = (int)reader.GetValue(1);
                    matiere.semestre = (string)reader.GetValue(2);
                    matiere.cofficient = (int)reader.GetValue(3);
                    matiere.crédit = (int)reader.GetValue(4);
                    matiere.idspecialite = (int)reader.GetValue(5);
                    matiere.idenseing = (int)reader.GetValue(6);



                    MatiereADOList.Add(matiere);


                }
                reader.Close();
            }

            public void insert(Matiere matiere)
            {


                SqlCommand cmd = new SqlCommand("insert into matiere (code, semestre ,cofficient ,crédit, idspecialite,idenseing) values ('" + matiere.Code + "' , '" + matiere.Semestre + "' , '" + matiere.Cofficient + "' , '" + matiere.Crédit + "', '" + matiere.IdSpecialite + "', '" + matiere.IdEnseing + "')");
                cnx.executeCommand(cmd);

            }
            public void update(Matiere matiere)
            {


                SqlCommand cmd = new SqlCommand("update  matiere set code ='" + matiere.Code + "' ,  semestre =  '" + matiere.Semestre + "' , cofficient =  '" + matiere.Cofficient + "' , crédit =  '" + matiere.Crédit + "' , idspecialite =  '" + matiere.IdSpecialite + "' ,idenseing =  '" + matiere.IdEnseing + "'where idmat = " + matiere.IdMat + "; ");
                cnx.executeCommand(cmd);
            }
            public void delete(Matiere matiere)
            {

                SqlCommand cmd = new SqlCommand("delete from  matiere  where idmat = " + matiere.IdMat + "; ");
                cnx.executeCommand(cmd);
            }

        }
    }

}
