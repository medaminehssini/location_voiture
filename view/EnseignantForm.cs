using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLLER;
using MODEL;
namespace view
{
    public partial class EnseignantForm : Form
    {
        EnseignantADO ensAdo;
        public EnseignantForm()
        {
            InitializeComponent();
            ensAdo = new EnseignantADO();
        }
        

   
       
      

       

       

       

       
       

      

        private void EnseignantForm_Load(object sender, EventArgs e)
        {

            EnseignantADO ensAdo = new EnseignantADO();
            ensAdo.load();

            enseignantBindingSource.DataSource = ensAdo.EnseignantADOList;
        }

        private void enseignantBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void nomTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            MODEL.Enseignant ens = new MODEL.Enseignant();
            ens.Nom = textBox1.Text;
            ens.Prenom = textBox2.Text;
            Console.WriteLine(guna2DateTimePicker1.Value);
            ens.Datenaiss = guna2DateTimePicker1.Value;
            ens.Lieu = textBox3.Text;
            ens.Email = textBox4.Text;
            ens.Password = textBox5.Text;
            ens.Login = textBox6.Text;
            ensAdo.insert(ens);
            

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            MODEL.Enseignant ens = (MODEL.Enseignant)enseignantBindingSource.Current;
            ensAdo.delete(ens);
            ensAdo.load();

            enseignantBindingSource.DataSource = ensAdo.EnseignantADOList;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            MODEL.Enseignant cl = (MODEL.Enseignant)enseignantBindingSource.Current;
            ensAdo.update(cl);

            ensAdo.load();

            enseignantBindingSource.DataSource = ensAdo.EnseignantADOList;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            enseignantBindingSource.AddNew();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enseignantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
