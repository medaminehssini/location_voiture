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
    public partial class SpecialiteForm : Form
    {
        SpecialiteADO spAdo;
        public SpecialiteForm()
        {
            InitializeComponent();
          spAdo = new SpecialiteADO();
        }



      
        private void SpecialiteForm_Load(object sender, EventArgs e)
        {
             spAdo = new SpecialiteADO();

            spAdo.load();
            specialiteBindingSource.DataSource = spAdo.SpecialiteADOList;

        }

      

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Specialite etud = new Specialite();

            etud.Acronyme = textBox1.Text;



            spAdo.insert(etud);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

            specialiteBindingSource.AddNew();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Specialite ar = (Specialite)specialiteBindingSource.Current;
            spAdo.delete(ar);
            spAdo.load();

            specialiteBindingSource.DataSource = spAdo.SpecialiteADOList;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Specialite etu = (Specialite)specialiteBindingSource.Current;
            spAdo.update(etu);

            spAdo.load();

            specialiteBindingSource.DataSource = spAdo.SpecialiteADOList;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
