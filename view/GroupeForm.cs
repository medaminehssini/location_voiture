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
    public partial class GroupeForm : Form
    {
        public GroupeADO grpAdo;
        public GroupeForm()
        {
            InitializeComponent();
            grpAdo = new GroupeADO();
        }
     

        private void GroupeForm_Load(object sender, EventArgs e)
        {
            grpAdo = new CONTROLLER.GroupeADO();
            grpAdo.load();

            groupeBindingSource.DataSource = grpAdo.groupeADOList;
        }

       

        

    
        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MODEL.Groupe gp = new MODEL.Groupe();
            gp.Nom = textBox1.Text;


            grpAdo.insert(gp);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            groupeBindingSource.AddNew();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            MODEL.Groupe ens = (MODEL.Groupe)groupeBindingSource.Current;
            grpAdo.delete(ens);
            grpAdo.load();

            groupeBindingSource.DataSource = grpAdo.groupeADOList;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            MODEL.Groupe cl = (MODEL.Groupe)groupeBindingSource.Current;
            grpAdo.update(cl);

            grpAdo.load();

            groupeBindingSource.DataSource = grpAdo.groupeADOList;
        }
    }
}
