using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER
{
    public class SpecialiteADO
    {
        public List<Specialite> SpecialiteADOList;
        Connection cnx = new Connection();


        public void load()
        {
            SpecialiteADOList = new List<Specialite>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM Specialite");
            while (reader.Read())
            {


                Specialite specialite = new Specialite();
                specialite.IdSpecialite = (int)reader.GetValue(0);
                specialite.Acronyme = (string)reader.GetValue(1);
                


                SpecialiteADOList.Add(specialite);


            }
            reader.Close();
        }

        public void insert(Specialite specialite)
        {


            SqlCommand cmd = new SqlCommand("insert into specialite (acronyme) values ('" + specialite.Acronyme + "')");
            cnx.executeCommand(cmd);

        }
        public void update(Specialite specialite)
        {


            SqlCommand cmd = new SqlCommand("update  specialite set acronyme =  '" + specialite.Acronyme + "' where idspecialite = " + specialite.IdSpecialite + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Specialite specialite)
        {

            SqlCommand cmd = new SqlCommand("delete from  specialite  where idspecialite = " + specialite.IdSpecialite + "; ");
            cnx.executeCommand(cmd);
        }

    }
}
    