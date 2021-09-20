namespace Academy_System
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentsPanel = new System.Windows.Forms.Panel();
            this.UpdtStdbtn = new System.Windows.Forms.Button();
            this.Deletestbtn = new System.Windows.Forms.Button();
            this.AddStudentbtn = new System.Windows.Forms.Button();
            this.Studentsdatagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.FeesBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Coursesbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.TeachersBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Studentsbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.StudentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Studentsdatagrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(166)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.StudentsPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StudentsPanel
            // 
            this.StudentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentsPanel.Controls.Add(this.UpdtStdbtn);
            this.StudentsPanel.Controls.Add(this.Deletestbtn);
            this.StudentsPanel.Controls.Add(this.AddStudentbtn);
            this.StudentsPanel.Controls.Add(this.Studentsdatagrid);
            this.StudentsPanel.Location = new System.Drawing.Point(167, 67);
            this.StudentsPanel.Name = "StudentsPanel";
            this.StudentsPanel.Size = new System.Drawing.Size(1195, 342);
            this.StudentsPanel.TabIndex = 2;
            // 
            // UpdtStdbtn
            // 
            this.UpdtStdbtn.Location = new System.Drawing.Point(281, 25);
            this.UpdtStdbtn.Name = "UpdtStdbtn";
            this.UpdtStdbtn.Size = new System.Drawing.Size(123, 37);
            this.UpdtStdbtn.TabIndex = 3;
            this.UpdtStdbtn.Text = "Update student record";
            this.UpdtStdbtn.UseVisualStyleBackColor = true;
            // 
            // Deletestbtn
            // 
            this.Deletestbtn.Location = new System.Drawing.Point(164, 25);
            this.Deletestbtn.Name = "Deletestbtn";
            this.Deletestbtn.Size = new System.Drawing.Size(89, 38);
            this.Deletestbtn.TabIndex = 2;
            this.Deletestbtn.Text = "Delete student";
            this.Deletestbtn.UseVisualStyleBackColor = true;
            this.Deletestbtn.Click += new System.EventHandler(this.Deletestbtn_Click);
            // 
            // AddStudentbtn
            // 
            this.AddStudentbtn.Location = new System.Drawing.Point(25, 24);
            this.AddStudentbtn.Name = "AddStudentbtn";
            this.AddStudentbtn.Size = new System.Drawing.Size(100, 38);
            this.AddStudentbtn.TabIndex = 1;
            this.AddStudentbtn.Text = "Add new Student";
            this.AddStudentbtn.UseVisualStyleBackColor = true;
            this.AddStudentbtn.Click += new System.EventHandler(this.AddStudentbtn_Click);
            // 
            // Studentsdatagrid
            // 
            this.Studentsdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Studentsdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Studentsdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Studentsdatagrid.Location = new System.Drawing.Point(3, 69);
            this.Studentsdatagrid.Name = "Studentsdatagrid";
            this.Studentsdatagrid.Size = new System.Drawing.Size(1195, 263);
            this.Studentsdatagrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Date of birth";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Father Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Start Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "End Date";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Course";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Phone";
            this.Column8.Name = "Column8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(251, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coaching Center Management ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.bunifuTileButton1);
            this.panel2.Controls.Add(this.FeesBtn);
            this.panel2.Controls.Add(this.Coursesbtn);
            this.panel2.Controls.Add(this.TeachersBtn);
            this.panel2.Controls.Add(this.Studentsbtn);
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 604);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Log Out";
            this.bunifuTileButton1.Location = new System.Drawing.Point(502, 370);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 12;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click_1);
            // 
            // FeesBtn
            // 
            this.FeesBtn.BackColor = System.Drawing.Color.Transparent;
            this.FeesBtn.color = System.Drawing.Color.SeaGreen;
            this.FeesBtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.FeesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FeesBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.FeesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FeesBtn.Image = ((System.Drawing.Image)(resources.GetObject("FeesBtn.Image")));
            this.FeesBtn.ImagePosition = 20;
            this.FeesBtn.ImageZoom = 50;
            this.FeesBtn.LabelPosition = 41;
            this.FeesBtn.LabelText = "Fee";
            this.FeesBtn.Location = new System.Drawing.Point(61, 370);
            this.FeesBtn.Margin = new System.Windows.Forms.Padding(6);
            this.FeesBtn.Name = "FeesBtn";
            this.FeesBtn.Size = new System.Drawing.Size(128, 129);
            this.FeesBtn.TabIndex = 11;
            this.FeesBtn.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // Coursesbtn
            // 
            this.Coursesbtn.BackColor = System.Drawing.Color.SeaGreen;
            this.Coursesbtn.color = System.Drawing.Color.SeaGreen;
            this.Coursesbtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Coursesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Coursesbtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Coursesbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Coursesbtn.Image = ((System.Drawing.Image)(resources.GetObject("Coursesbtn.Image")));
            this.Coursesbtn.ImagePosition = 20;
            this.Coursesbtn.ImageZoom = 50;
            this.Coursesbtn.LabelPosition = 41;
            this.Coursesbtn.LabelText = "Courses";
            this.Coursesbtn.Location = new System.Drawing.Point(981, 108);
            this.Coursesbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Coursesbtn.Name = "Coursesbtn";
            this.Coursesbtn.Size = new System.Drawing.Size(128, 129);
            this.Coursesbtn.TabIndex = 10;
            this.Coursesbtn.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // TeachersBtn
            // 
            this.TeachersBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeachersBtn.color = System.Drawing.SystemColors.ButtonHighlight;
            this.TeachersBtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.TeachersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeachersBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.TeachersBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TeachersBtn.Image = ((System.Drawing.Image)(resources.GetObject("TeachersBtn.Image")));
            this.TeachersBtn.ImagePosition = 20;
            this.TeachersBtn.ImageZoom = 50;
            this.TeachersBtn.LabelPosition = 41;
            this.TeachersBtn.LabelText = "Teacher";
            this.TeachersBtn.Location = new System.Drawing.Point(502, 108);
            this.TeachersBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TeachersBtn.Name = "TeachersBtn";
            this.TeachersBtn.Size = new System.Drawing.Size(128, 129);
            this.TeachersBtn.TabIndex = 9;
            this.TeachersBtn.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // Studentsbtn
            // 
            this.Studentsbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Studentsbtn.color = System.Drawing.SystemColors.ButtonHighlight;
            this.Studentsbtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Studentsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Studentsbtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Studentsbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Studentsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Studentsbtn.Image")));
            this.Studentsbtn.ImagePosition = 20;
            this.Studentsbtn.ImageZoom = 50;
            this.Studentsbtn.LabelPosition = 41;
            this.Studentsbtn.LabelText = "Student";
            this.Studentsbtn.Location = new System.Drawing.Point(61, 108);
            this.Studentsbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Studentsbtn.Name = "Studentsbtn";
            this.Studentsbtn.Size = new System.Drawing.Size(128, 129);
            this.Studentsbtn.TabIndex = 8;
            this.Studentsbtn.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(174, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StudentsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Studentsdatagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel StudentsPanel;
        private System.Windows.Forms.Button UpdtStdbtn;
        private System.Windows.Forms.Button Deletestbtn;
        private System.Windows.Forms.Button AddStudentbtn;
        private System.Windows.Forms.DataGridView Studentsdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton FeesBtn;
        private Bunifu.Framework.UI.BunifuTileButton Coursesbtn;
        private Bunifu.Framework.UI.BunifuTileButton TeachersBtn;
        private Bunifu.Framework.UI.BunifuTileButton Studentsbtn;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}