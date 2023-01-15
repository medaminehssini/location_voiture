namespace view
{
    partial class MatiereForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label cofficientLabel;
            System.Windows.Forms.Label créditLabel;
            System.Windows.Forms.Label semestreLabel;
            System.Windows.Forms.Label idEnseingLabel;
            System.Windows.Forms.Label idSpecialiteLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialiteComboBox = new System.Windows.Forms.ComboBox();
            this.enseignantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enseignantComboBox = new System.Windows.Forms.ComboBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cofficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.créditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEnseingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            codeLabel = new System.Windows.Forms.Label();
            cofficientLabel = new System.Windows.Forms.Label();
            créditLabel = new System.Windows.Forms.Label();
            semestreLabel = new System.Windows.Forms.Label();
            idEnseingLabel = new System.Windows.Forms.Label();
            idSpecialiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enseignantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.BackColor = System.Drawing.Color.White;
            codeLabel.Location = new System.Drawing.Point(27, 48);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "Code:";
            // 
            // cofficientLabel
            // 
            cofficientLabel.AutoSize = true;
            cofficientLabel.BackColor = System.Drawing.Color.White;
            cofficientLabel.Location = new System.Drawing.Point(8, 129);
            cofficientLabel.Name = "cofficientLabel";
            cofficientLabel.Size = new System.Drawing.Size(54, 13);
            cofficientLabel.TabIndex = 3;
            cofficientLabel.Text = "Cofficient:";
            // 
            // créditLabel
            // 
            créditLabel.AutoSize = true;
            créditLabel.BackColor = System.Drawing.Color.White;
            créditLabel.Location = new System.Drawing.Point(24, 174);
            créditLabel.Name = "créditLabel";
            créditLabel.Size = new System.Drawing.Size(37, 13);
            créditLabel.TabIndex = 5;
            créditLabel.Text = "Crédit:";
            // 
            // semestreLabel
            // 
            semestreLabel.AutoSize = true;
            semestreLabel.BackColor = System.Drawing.Color.White;
            semestreLabel.Location = new System.Drawing.Point(8, 90);
            semestreLabel.Name = "semestreLabel";
            semestreLabel.Size = new System.Drawing.Size(54, 13);
            semestreLabel.TabIndex = 13;
            semestreLabel.Text = "Semestre:";
            // 
            // idEnseingLabel
            // 
            idEnseingLabel.AutoSize = true;
            idEnseingLabel.BackColor = System.Drawing.Color.White;
            idEnseingLabel.Location = new System.Drawing.Point(215, 109);
            idEnseingLabel.Name = "idEnseingLabel";
            idEnseingLabel.Size = new System.Drawing.Size(88, 13);
            idEnseingLabel.TabIndex = 20;
            idEnseingLabel.Text = "Nom Enseignant:";
            // 
            // idSpecialiteLabel
            // 
            idSpecialiteLabel.AutoSize = true;
            idSpecialiteLabel.BackColor = System.Drawing.Color.White;
            idSpecialiteLabel.Location = new System.Drawing.Point(226, 52);
            idSpecialiteLabel.Name = "idSpecialiteLabel";
            idSpecialiteLabel.Size = new System.Drawing.Size(78, 13);
            idSpecialiteLabel.TabIndex = 19;
            idSpecialiteLabel.Text = "NomSpecialite:";
            // 
            // matiereBindingSource
            // 
            this.matiereBindingSource.DataSource = typeof(MODEL.Matiere);
            // 
            // specialiteBindingSource
            // 
            this.specialiteBindingSource.DataSource = typeof(MODEL.Specialite);
            // 
            // specialiteComboBox
            // 
            this.specialiteComboBox.BackColor = System.Drawing.Color.Coral;
            this.specialiteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialiteBindingSource, "IdSpecialite", true));
            this.specialiteComboBox.DataSource = this.specialiteBindingSource;
            this.specialiteComboBox.DisplayMember = "Acronyme";
            this.specialiteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialiteComboBox.FormattingEnabled = true;
            this.specialiteComboBox.Location = new System.Drawing.Point(308, 49);
            this.specialiteComboBox.Name = "specialiteComboBox";
            this.specialiteComboBox.Size = new System.Drawing.Size(76, 21);
            this.specialiteComboBox.TabIndex = 20;
            this.specialiteComboBox.ValueMember = "IdSpecialite";
            this.specialiteComboBox.SelectedIndexChanged += new System.EventHandler(this.specialiteComboBox_SelectedIndexChanged);
            // 
            // enseignantBindingSource
            // 
            this.enseignantBindingSource.DataSource = typeof(MODEL.Enseignant);
            // 
            // enseignantComboBox
            // 
            this.enseignantComboBox.BackColor = System.Drawing.Color.Coral;
            this.enseignantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enseignantBindingSource, "Idenseing", true));
            this.enseignantComboBox.DataSource = this.enseignantBindingSource;
            this.enseignantComboBox.DisplayMember = "Email";
            this.enseignantComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enseignantComboBox.FormattingEnabled = true;
            this.enseignantComboBox.Location = new System.Drawing.Point(308, 106);
            this.enseignantComboBox.Name = "enseignantComboBox";
            this.enseignantComboBox.Size = new System.Drawing.Size(82, 21);
            this.enseignantComboBox.TabIndex = 20;
            this.enseignantComboBox.ValueMember = "Idenseing";
            this.enseignantComboBox.SelectedIndexChanged += new System.EventHandler(this.enseignantComboBox_SelectedIndexChanged);
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Animated = true;
            this.guna2TextBox4.BackColor = System.Drawing.Color.White;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.LightGray;
            this.guna2TextBox4.BorderRadius = 10;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(364, 327);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.PlaceholderText = "Tappez password";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(123, 25);
            this.guna2TextBox4.TabIndex = 43;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Animated = true;
            this.guna2TextBox6.BorderRadius = 10;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(364, 362);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox6.PlaceholderText = "Tapez le login";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(123, 25);
            this.guna2TextBox6.TabIndex = 45;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(481, 45);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(93, 35);
            this.guna2GradientButton1.TabIndex = 56;
            this.guna2GradientButton1.Text = "Ajouter";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 10;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Location = new System.Drawing.Point(481, 87);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(93, 35);
            this.guna2GradientButton4.TabIndex = 59;
            this.guna2GradientButton4.Text = "Enregistrer";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(481, 139);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(93, 35);
            this.guna2GradientButton2.TabIndex = 57;
            this.guna2GradientButton2.Text = "Supprimer";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(481, 190);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(98, 35);
            this.guna2GradientButton3.TabIndex = 58;
            this.guna2GradientButton3.Text = "Mettre a jour";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.semestreDataGridViewTextBoxColumn,
            this.cofficientDataGridViewTextBoxColumn,
            this.créditDataGridViewTextBoxColumn,
            this.idSpecialiteDataGridViewTextBoxColumn,
            this.idMatDataGridViewTextBoxColumn,
            this.idEnseingDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.matiereBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(30, 247);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(549, 150);
            this.guna2DataGridView1.TabIndex = 60;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // semestreDataGridViewTextBoxColumn
            // 
            this.semestreDataGridViewTextBoxColumn.DataPropertyName = "Semestre";
            this.semestreDataGridViewTextBoxColumn.HeaderText = "Semestre";
            this.semestreDataGridViewTextBoxColumn.Name = "semestreDataGridViewTextBoxColumn";
            // 
            // cofficientDataGridViewTextBoxColumn
            // 
            this.cofficientDataGridViewTextBoxColumn.DataPropertyName = "Cofficient";
            this.cofficientDataGridViewTextBoxColumn.HeaderText = "Cofficient";
            this.cofficientDataGridViewTextBoxColumn.Name = "cofficientDataGridViewTextBoxColumn";
            // 
            // créditDataGridViewTextBoxColumn
            // 
            this.créditDataGridViewTextBoxColumn.DataPropertyName = "Crédit";
            this.créditDataGridViewTextBoxColumn.HeaderText = "Crédit";
            this.créditDataGridViewTextBoxColumn.Name = "créditDataGridViewTextBoxColumn";
            // 
            // idSpecialiteDataGridViewTextBoxColumn
            // 
            this.idSpecialiteDataGridViewTextBoxColumn.DataPropertyName = "IdSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.HeaderText = "IdSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.Name = "idSpecialiteDataGridViewTextBoxColumn";
            // 
            // idMatDataGridViewTextBoxColumn
            // 
            this.idMatDataGridViewTextBoxColumn.DataPropertyName = "IdMat";
            this.idMatDataGridViewTextBoxColumn.HeaderText = "IdMat";
            this.idMatDataGridViewTextBoxColumn.Name = "idMatDataGridViewTextBoxColumn";
            // 
            // idEnseingDataGridViewTextBoxColumn
            // 
            this.idEnseingDataGridViewTextBoxColumn.DataPropertyName = "IdEnseing";
            this.idEnseingDataGridViewTextBoxColumn.HeaderText = "IdEnseing";
            this.idEnseingDataGridViewTextBoxColumn.Name = "idEnseingDataGridViewTextBoxColumn";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Controls.Add(this.textBox4);
            this.guna2GradientPanel1.Controls.Add(this.textBox3);
            this.guna2GradientPanel1.Controls.Add(this.textBox2);
            this.guna2GradientPanel1.Controls.Add(this.textBox1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 562);
            this.guna2GradientPanel1.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matiereBindingSource, "Code", true));
            this.textBox1.Location = new System.Drawing.Point(69, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matiereBindingSource, "Semestre", true));
            this.textBox2.Location = new System.Drawing.Point(69, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matiereBindingSource, "Cofficient", true));
            this.textBox3.Location = new System.Drawing.Point(69, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matiereBindingSource, "Crédit", true));
            this.textBox4.Location = new System.Drawing.Point(69, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // MatiereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.enseignantComboBox);
            this.Controls.Add(this.specialiteComboBox);
            this.Controls.Add(idEnseingLabel);
            this.Controls.Add(idSpecialiteLabel);
            this.Controls.Add(semestreLabel);
            this.Controls.Add(créditLabel);
            this.Controls.Add(cofficientLabel);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "MatiereForm";
            this.Text = "Matiere";
            this.Load += new System.EventHandler(this.MatiereForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enseignantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource matiereBindingSource;
        private System.Windows.Forms.BindingSource specialiteBindingSource;
        private System.Windows.Forms.ComboBox specialiteComboBox;
        private System.Windows.Forms.BindingSource enseignantBindingSource;
        private System.Windows.Forms.ComboBox enseignantComboBox;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cofficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn créditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecialiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnseingDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}