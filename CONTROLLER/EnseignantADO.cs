using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class EnseignantADO
    {

        public List<Enseignant> EnseignantADOList;
        Connection cnx = new Connection();
        public object enseignantADO;

        public void load()
        {
            EnseignantADOList = new List<Enseignant>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM Enseignant");
            while (reader.Read())
            {
                Console.WriteLine("hhhh");


        Enseignant enseignant = new Enseignant();
                enseignant.Idenseing = (int)reader.GetValue(0);
                enseignant.Nom= (string)reader.GetValue(1);
                enseignant.Prenom = (string)reader.GetValue(2);
                enseignant.Datenaiss = (DateTime)reader.GetValue(3);
        enseignant.Lieu = (string) reader.GetValue(4);

        enseignant.Email = (string) reader.GetValue(5);
        enseignant.Password = (string)reader.GetValue(6);
                enseignant.Login = (string)reader.GetValue(7);



                EnseignantADOList.Add(enseignant);


            }
            reader.Close();
        }

        public void insert(Enseignant enseignant)
        {


            SqlCommand cmd = new SqlCommand("insert into enseignant (nom, prenom ,datenaiss ,lieu, email,password,login) values ('" + enseignant.Nom + "' , '" + enseignant.Prenom + "' , convert(date, '" + enseignant.Datenaiss + "', 105) , '" + enseignant.Lieu + "' , '" + enseignant.Email + "', '" + enseignant.Password + "', '" + enseignant.Login + "')");
            cnx.executeCommand(cmd);

        }

        public void insert(Note not)
        {
            throw new NotImplementedException();
        }

        public void delete(Note note)
        {
            throw new NotImplementedException();
        }

        public void update(Enseignant enseignant)
        {


            SqlCommand cmd = new SqlCommand("update  enseignant set nom ='" + enseignant.Nom + "' ,  prenom =  '" + enseignant.Prenom + "' , datenaiss = convert(date, '" + enseignant.Datenaiss + "',105)   , lieu =  '" + enseignant.Lieu + "' , email =  '" + enseignant.Email + "' , password =  '" + enseignant.Password + "' ,login =  '" + enseignant.Login + "' where idenseing = " + enseignant.Idenseing + "; ");
            cnx.executeCommand(cmd);
        }

        public void update(Note n)
        {
            throw new NotImplementedException();
        }

        public void delete(Enseignant enseignant)
        {

            SqlCommand cmd = new SqlCommand("delete from  enseignant  where idenseing = " + enseignant.Idenseing + "; ");
            cnx.executeCommand(cmd);
        }

    }
}
