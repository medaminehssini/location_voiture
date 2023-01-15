using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace view
{
    public partial class menu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public menu()
        {
            InitializeComponent();
            random=new Random();
            btnCloseChildForm.Visible = false;
        }
        private Color SelectThemeColor()
        {
            int index=random.Next(ThemeColor.colorsList.Count);
            while (tempIndex == index)
            {
               index= random.Next(ThemeColor.colorsList.Count);
            }
            tempIndex = index;
            string color=ThemeColor.colorsList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton(); 
                    Color color=SelectThemeColor();
                    currentButton=(Button)btnSender;
                    currentButton.BackColor=color;
                    currentButton.ForeColor = Color.White;
                    panel3.BackColor=color;
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    
                }
            }
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktoPpan.Controls.Add(childForm);
            this.panelDesktoPpan.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EtudiantForm(), sender);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void etudiant_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GroupeForm(), sender);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SpecialiteForm(), sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EnseignantForm(), sender);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MatiereForm(), sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {


            OpenChildForm(new NoteForm(), sender);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
       
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panel3.BackColor = Color.FromArgb(255,250,240);
            currentButton = null;
            btnCloseChildForm.Visible = false;
          
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }
    }
}