using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class EtudiantADO
    {

        public List<Etudiant> etudiantADOList  = new List<Etudiant>();
        Connection cnx = new Connection();


        public void load()
        {
       
            SqlDataReader reader = cnx.SDD("select * from etudiant");
            while (reader.Read())
            {


                Etudiant etud = new Etudiant();
                etud.IdEtud = (int)reader.GetValue(0);
                etud.Nom = (string)reader.GetValue(1);
                etud.Prenom = (string)reader.GetValue(2);
                etud.Datenaiss = (DateTime) reader.GetValue(3);
                etud.Password = (string)reader.GetValue(4);
                etud.Login = (string)reader.GetValue(5);
                etud.IdGroupe = (int) reader.GetValue(6);



                etudiantADOList.Add(etud);


            }
        
            reader.Close();
        }

        public void insert(Etudiant etudiant)
        {


            SqlCommand cmd = new SqlCommand("insert into etudiant (nom, prenom ,datenaiss ,password, login,idgroupe) values ('" + etudiant.Nom + "' , '" + etudiant.Prenom + "' , convert(date, '" + etudiant.Datenaiss + "', 105) , '" + etudiant.Password + "', '" + etudiant.Login + "', '" + etudiant.IdGroupe + "')");
            cnx.executeCommand(cmd);

        }
        public void update(Etudiant etudiant)
        {


            SqlCommand cmd = new SqlCommand("update  etudiant set nom ='" + etudiant.Nom + "' ,  prenom =  '" + etudiant.Prenom + "' , datenaiss =  convert(date, '" + etudiant.Datenaiss + "', 105) , password =  '" + etudiant.Password + "' , login =  '" + etudiant.Login + "' ,idgroupe =  '" + etudiant.IdGroupe + "' where idetud = " + etudiant.IdEtud + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Etudiant etudiant)
        {

            SqlCommand cmd = new SqlCommand("delete from  etudiant  where idetud = " + etudiant.IdEtud + "; ");
            cnx.executeCommand(cmd);
        }

    }
}
