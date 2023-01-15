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
namespace view
{
    public partial class EtudiantForm : Form
    {
        EtudiantADO etudAdo;
        public EtudiantForm()
        {
            InitializeComponent();
            etudAdo = new EtudiantADO();
        }



        private void groupeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           GroupeADO gado = new GroupeADO();

            gado.load();
            groupeBindingSource1.DataSource = gado.groupeADOList;

           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        

        private void EtudiantForm_Load(object sender, EventArgs e)
        {
            GroupeADO grp = new GroupeADO();
            grp.load();
            groupeBindingSource1.DataSource = grp.groupeADOList;

            EtudiantADO ado=new EtudiantADO();
            ado.load();
          
            etudiantBindingSource.DataSource = ado.etudiantADOList;
        }

        private void groupeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void etudiantDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupeComboBox_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void groupeComboBox_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            GroupeADO grp = new GroupeADO();
            grp.load();
            groupeBindingSource1.DataSource = grp.groupeADOList;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Etudiant etud = new Etudiant();

            etud.Nom = textBox1.Text;
            etud.Prenom = textBox3.Text;
            etud.Datenaiss = DateTime.Parse(guna2DateTimePicker1.Text);
            etud.Password = textBox4.Text;
            etud.Login = textBox2.Text;
            Groupe gr = new Groupe();
            gr = (Groupe)groupeBindingSource1.Current;
            etud.IdGroupe = gr.Idgroupe;
            etudAdo.insert(etud);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            etudiantBindingSource.AddNew();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            Etudiant ar = (Etudiant)etudiantBindingSource.Current;
            etudAdo.delete(ar);
            etudAdo.load();

            etudiantBindingSource.DataSource = etudAdo.etudiantADOList;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            Etudiant etu = (Etudiant)etudiantBindingSource.Current;
            etudAdo.update(etu);

            etudAdo.load();

            etudiantBindingSource.DataSource = etudAdo.etudiantADOList;

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
