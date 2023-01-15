



    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MODEL;

    namespace CONTROLLER
    {
        public class NoteADO
        {

            public List<Note> NoteADOList;
            Connection cnx = new Connection();


            public void load()
            {
                NoteADOList = new List<Note>();
                SqlDataReader reader = cnx.SDD("SELECT * FROM Note");
                while (reader.Read())
                {


                    Note note = new Note();
                    note.td = (float)reader.GetValue(0);
                    note.tp = (float)reader.GetValue(1);
                    note.examen = (float)reader.GetValue(2);
               
                    note.idmat = (int)reader.GetValue(3);
                    note.idetud= (int)reader.GetValue(4);



                    NoteADOList.Add(note);


                }
                reader.Close();
            }

            public void insert(Note note)
            {


                SqlCommand cmd = new SqlCommand("insert into note (td, tp ,examen ,idmat, idetud) values ('" + note.Tp + "', '" + note.Td + "' , '" + note.Examen + "' , '" + note.IdMat + "' , '" + note.IdEtud + "')");
                cnx.executeCommand(cmd);

            }
            public void update(Note note)
            {


                SqlCommand cmd = new SqlCommand("update  note set td ='" + note.Td + "' ,  tp =  '" + note.Tp + "' , examen =  '" + note.Examen + "' , idmat =  '" + note.IdMat + "' , idetud =  '" + note.IdEtud + "'where idnote = " + note.IdNote + "; ");
                cnx.executeCommand(cmd);
            }
            public void delete(Note note)
            {

                SqlCommand cmd = new SqlCommand("delete from  note  where id = " + note.IdMat + "; ");
                cnx.executeCommand(cmd);
            }

        }
    }


