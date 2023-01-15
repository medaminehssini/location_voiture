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
    public partial class NoteForm : Form
    {
        NoteADO etudAdo;
        public NoteForm()
        {
            InitializeComponent();
            etudAdo = new NoteADO();
        }

       

        private void NoteForm_Load(object sender, EventArgs e)
        {
           
            MatiereADO grp = new MatiereADO();
            grp.load();
           matiereBindingSource.DataSource = grp.MatiereADOList;

            EtudiantADO ado = new EtudiantADO();
            ado.load();

            etudiantBindingSource.DataSource = ado.etudiantADOList;
        }

       

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Note etud = new Note();

            etud.Td = float.Parse(textBox1.Text);
            etud.Tp = float.Parse(textBox2.Text);
            etud.Examen = float.Parse(textBox3.Text);

            Etudiant gr = new Etudiant();
            gr = (Etudiant)etudiantBindingSource.Current;
            etud.IdEtud = gr.idetud;

            Matiere gm = new Matiere();
            gm = (Matiere)matiereBindingSource.Current;
            etud.IdMat = gm.idmat;

            etudAdo.insert(etud);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            noteBindingSource.AddNew();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Note ar = (Note)noteBindingSource.Current;
            etudAdo.delete(ar);
            etudAdo.load();

            noteBindingSource.DataSource = etudAdo.NoteADOList;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Note etu = (Note)noteBindingSource.Current;
            etudAdo.update(etu);

            etudAdo.load();

            noteBindingSource.DataSource = etudAdo.NoteADOList;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NoteADO nt = new NoteADO();
            nt.load();
            noteBindingSource.DataSource = nt.NoteADOList;

        }
    }
}
