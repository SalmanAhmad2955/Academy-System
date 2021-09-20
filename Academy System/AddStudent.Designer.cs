namespace Academy_System
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.Numberofcrses = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalfee = new System.Windows.Forms.Label();
            this.txtStudentid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtemail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFathername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStudentname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DObdateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.EnddatedateTimePicker3 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.startdatedateTimePicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Student";
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GendercomboBox.Location = new System.Drawing.Point(279, 180);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(130, 21);
            this.GendercomboBox.TabIndex = 21;
            this.GendercomboBox.Text = "Select Gender";
            // 
            // Numberofcrses
            // 
            this.Numberofcrses.FormattingEnabled = true;
            this.Numberofcrses.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Numberofcrses.Location = new System.Drawing.Point(279, 281);
            this.Numberofcrses.Name = "Numberofcrses";
            this.Numberofcrses.Size = new System.Drawing.Size(121, 21);
            this.Numberofcrses.TabIndex = 22;
            this.Numberofcrses.Text = "Number of Courses";
            this.Numberofcrses.SelectedIndexChanged += new System.EventHandler(this.Numberofcrses_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(290, 336);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "PHP";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(369, 336);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 17);
            this.checkBox3.TabIndex = 26;
            this.checkBox3.Text = ".NET";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(511, 336);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 27;
            this.checkBox4.Text = "Networking";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(616, 337);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(115, 17);
            this.checkBox5.TabIndex = 28;
            this.checkBox5.Text = "Web Development";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(99, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total fee=";
            // 
            // totalfee
            // 
            this.totalfee.AutoSize = true;
            this.totalfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfee.Location = new System.Drawing.Point(535, 399);
            this.totalfee.Name = "totalfee";
            this.totalfee.Size = new System.Drawing.Size(0, 16);
            this.totalfee.TabIndex = 30;
            // 
            // txtStudentid
            // 
            this.txtStudentid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStudentid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStudentid.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStudentid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentid.HintForeColor = System.Drawing.Color.Empty;
            this.txtStudentid.HintText = "";
            this.txtStudentid.isPassword = false;
            this.txtStudentid.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStudentid.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStudentid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStudentid.LineThickness = 3;
            this.txtStudentid.Location = new System.Drawing.Point(279, 51);
            this.txtStudentid.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentid.MaxLength = 32767;
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(256, 30);
            this.txtStudentid.TabIndex = 31;
            this.txtStudentid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentid.OnValueChanged += new System.EventHandler(this.txtStudentid_OnValueChanged);
            // 
            // txtemail
            // 
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtemail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtemail.HintForeColor = System.Drawing.Color.Empty;
            this.txtemail.HintText = "";
            this.txtemail.isPassword = false;
            this.txtemail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtemail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtemail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtemail.LineThickness = 3;
            this.txtemail.Location = new System.Drawing.Point(279, 365);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(256, 30);
            this.txtemail.TabIndex = 32;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtphone
            // 
            this.txtphone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtphone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtphone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtphone.HintForeColor = System.Drawing.Color.Empty;
            this.txtphone.HintText = "";
            this.txtphone.isPassword = false;
            this.txtphone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtphone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtphone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtphone.LineThickness = 3;
            this.txtphone.Location = new System.Drawing.Point(279, 413);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.MaxLength = 32767;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(256, 30);
            this.txtphone.TabIndex = 33;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFathername
            // 
            this.txtFathername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFathername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFathername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFathername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFathername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFathername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFathername.HintForeColor = System.Drawing.Color.Empty;
            this.txtFathername.HintText = "";
            this.txtFathername.isPassword = false;
            this.txtFathername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFathername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFathername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFathername.LineThickness = 3;
            this.txtFathername.Location = new System.Drawing.Point(279, 132);
            this.txtFathername.Margin = new System.Windows.Forms.Padding(4);
            this.txtFathername.MaxLength = 32767;
            this.txtFathername.Name = "txtFathername";
            this.txtFathername.Size = new System.Drawing.Size(256, 30);
            this.txtFathername.TabIndex = 34;
            this.txtFathername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStudentname
            // 
            this.txtStudentname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStudentname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStudentname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStudentname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentname.HintForeColor = System.Drawing.Color.Empty;
            this.txtStudentname.HintText = "";
            this.txtStudentname.isPassword = false;
            this.txtStudentname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStudentname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStudentname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStudentname.LineThickness = 3;
            this.txtStudentname.Location = new System.Drawing.Point(279, 90);
            this.txtStudentname.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentname.MaxLength = 32767;
            this.txtStudentname.Name = "txtStudentname";
            this.txtStudentname.Size = new System.Drawing.Size(256, 30);
            this.txtStudentname.TabIndex = 35;
            this.txtStudentname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DObdateTimePicker1
            // 
            this.DObdateTimePicker1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DObdateTimePicker1.BorderRadius = 0;
            this.DObdateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.DObdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DObdateTimePicker1.FormatCustom = null;
            this.DObdateTimePicker1.Location = new System.Drawing.Point(279, 222);
            this.DObdateTimePicker1.Name = "DObdateTimePicker1";
            this.DObdateTimePicker1.Size = new System.Drawing.Size(256, 31);
            this.DObdateTimePicker1.TabIndex = 41;
            this.DObdateTimePicker1.Value = new System.DateTime(2018, 5, 26, 21, 25, 48, 69);
            // 
            // EnddatedateTimePicker3
            // 
            this.EnddatedateTimePicker3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnddatedateTimePicker3.BorderRadius = 0;
            this.EnddatedateTimePicker3.ForeColor = System.Drawing.Color.White;
            this.EnddatedateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EnddatedateTimePicker3.FormatCustom = null;
            this.EnddatedateTimePicker3.Location = new System.Drawing.Point(279, 508);
            this.EnddatedateTimePicker3.Name = "EnddatedateTimePicker3";
            this.EnddatedateTimePicker3.Size = new System.Drawing.Size(256, 31);
            this.EnddatedateTimePicker3.TabIndex = 42;
            this.EnddatedateTimePicker3.Value = new System.DateTime(2018, 5, 26, 21, 25, 48, 69);
            // 
            // startdatedateTimePicker2
            // 
            this.startdatedateTimePicker2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startdatedateTimePicker2.BorderRadius = 0;
            this.startdatedateTimePicker2.ForeColor = System.Drawing.Color.White;
            this.startdatedateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startdatedateTimePicker2.FormatCustom = null;
            this.startdatedateTimePicker2.Location = new System.Drawing.Point(279, 463);
            this.startdatedateTimePicker2.Name = "startdatedateTimePicker2";
            this.startdatedateTimePicker2.Size = new System.Drawing.Size(256, 31);
            this.startdatedateTimePicker2.TabIndex = 43;
            this.startdatedateTimePicker2.Value = new System.DateTime(2018, 5, 26, 21, 25, 48, 69);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.startdatedateTimePicker2);
            this.panel1.Controls.Add(this.EnddatedateTimePicker3);
            this.panel1.Controls.Add(this.DObdateTimePicker1);
            this.panel1.Controls.Add(this.txtStudentname);
            this.panel1.Controls.Add(this.txtFathername);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtStudentid);
            this.panel1.Controls.Add(this.totalfee);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.Numberofcrses);
            this.panel1.Controls.Add(this.GendercomboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 634);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(99, 59);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 22);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Student ID:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(99, 98);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(148, 22);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Student Name:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(99, 140);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(135, 22);
            this.bunifuCustomLabel3.TabIndex = 46;
            this.bunifuCustomLabel3.Text = "Father Name:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(99, 179);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(87, 22);
            this.bunifuCustomLabel4.TabIndex = 47;
            this.bunifuCustomLabel4.Text = "Gender:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(99, 231);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(128, 22);
            this.bunifuCustomLabel5.TabIndex = 48;
            this.bunifuCustomLabel5.Text = "Date of Birth:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(99, 281);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(170, 22);
            this.bunifuCustomLabel6.TabIndex = 49;
            this.bunifuCustomLabel6.Text = "Name of Courses:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(99, 472);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 22);
            this.bunifuCustomLabel7.TabIndex = 50;
            this.bunifuCustomLabel7.Text = "Start Date:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(99, 517);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(101, 22);
            this.bunifuCustomLabel8.TabIndex = 51;
            this.bunifuCustomLabel8.Text = "End Date:";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(99, 373);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(61, 22);
            this.bunifuCustomLabel9.TabIndex = 52;
            this.bunifuCustomLabel9.Text = "Email:";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(99, 421);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(79, 22);
            this.bunifuCustomLabel10.TabIndex = 53;
            this.bunifuCustomLabel10.Text = "Cell No:";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(99, 331);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(146, 22);
            this.bunifuCustomLabel11.TabIndex = 54;
            this.bunifuCustomLabel11.Text = "Select Courses:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(441, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Java";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add Student";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(330, 585);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(160, 44);
            this.bunifuThinButton21.TabIndex = 56;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(270, 33);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(265, 17);
            this.bunifuSeparator1.TabIndex = 57;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 632);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.ComboBox Numberofcrses;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalfee;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStudentid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtemail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFathername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStudentname;
        private Bunifu.Framework.UI.BunifuDatepicker DObdateTimePicker1;
        private Bunifu.Framework.UI.BunifuDatepicker EnddatedateTimePicker3;
        private Bunifu.Framework.UI.BunifuDatepicker startdatedateTimePicker2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}