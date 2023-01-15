using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using CONTROLLER;
using CONTROLLER.CONTROLLER;

namespace view
{
    public partial class MatiereForm : Form
    {
        MatiereADO etudAdo;
        public MatiereForm()
        {
            InitializeComponent();
            etudAdo = new MatiereADO();
        }



      

       

      

    
        private void MatiereForm_Load(object sender, EventArgs e)
        {
            MatiereADO ado = new MatiereADO();
            ado.load();

            matiereBindingSource.DataSource = ado.MatiereADOList;

            SpecialiteADO grp = new SpecialiteADO();
            grp.load();
            specialiteBindingSource.DataSource = grp.SpecialiteADOList;

            EnseignantADO adoo = new EnseignantADO();
            adoo.load();

            enseignantBindingSource.DataSource = adoo.EnseignantADOList;
        }

      
       

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void enseignantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void specialiteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Matiere etud = new Matiere();


            etud.Code = Int32.Parse(textBox1.Text);
            etud.Cofficient = Int32.Parse(textBox3.Text);
            etud.Crédit = Int32.Parse(textBox4.Text);
            etud.Semestre = textBox2.Text;

            Enseignant gr = new Enseignant();
            gr = (Enseignant)enseignantBindingSource.Current;
            etud.IdEnseing = gr.idenseing;

            Specialite gm = new Specialite();
            gm = (Specialite)specialiteBindingSource.Current;
            etud.idspecialite = gm.idspecialite;

            etudAdo.insert(etud);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            matiereBindingSource.AddNew();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Matiere ar = (Matiere)matiereBindingSource.Current;
            etudAdo.delete(ar);
            etudAdo.load();

            matiereBindingSource.DataSource = etudAdo.MatiereADOList;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Matiere etu = (Matiere)matiereBindingSource.Current;
            etudAdo.update(etu);

            etudAdo.load();

            matiereBindingSource.DataSource = etudAdo.MatiereADOList;
        }
    }
}
