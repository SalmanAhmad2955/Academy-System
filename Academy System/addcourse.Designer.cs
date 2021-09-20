namespace Academy_System
{
    partial class addcourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcourse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.EnddatedateTimePicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.startdatedateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtcrscode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcrsfee = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcrstchr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcrstitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txtcrstitle);
            this.panel1.Controls.Add(this.txtcrstchr);
            this.panel1.Controls.Add(this.txtcrsfee);
            this.panel1.Controls.Add(this.txtcrscode);
            this.panel1.Controls.Add(this.startdatedateTimePicker1);
            this.panel1.Controls.Add(this.EnddatedateTimePicker2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 388);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Add New Course";
            // 
            // EnddatedateTimePicker2
            // 
            this.EnddatedateTimePicker2.BackColor = System.Drawing.Color.Black;
            this.EnddatedateTimePicker2.BorderRadius = 0;
            this.EnddatedateTimePicker2.ForeColor = System.Drawing.Color.White;
            this.EnddatedateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EnddatedateTimePicker2.FormatCustom = null;
            this.EnddatedateTimePicker2.Location = new System.Drawing.Point(341, 305);
            this.EnddatedateTimePicker2.Name = "EnddatedateTimePicker2";
            this.EnddatedateTimePicker2.Size = new System.Drawing.Size(262, 36);
            this.EnddatedateTimePicker2.TabIndex = 14;
            this.EnddatedateTimePicker2.Value = new System.DateTime(2018, 5, 26, 20, 57, 16, 379);
            // 
            // startdatedateTimePicker1
            // 
            this.startdatedateTimePicker1.BackColor = System.Drawing.Color.Black;
            this.startdatedateTimePicker1.BorderRadius = 0;
            this.startdatedateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.startdatedateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startdatedateTimePicker1.FormatCustom = null;
            this.startdatedateTimePicker1.Location = new System.Drawing.Point(341, 249);
            this.startdatedateTimePicker1.Name = "startdatedateTimePicker1";
            this.startdatedateTimePicker1.Size = new System.Drawing.Size(262, 36);
            this.startdatedateTimePicker1.TabIndex = 15;
            this.startdatedateTimePicker1.Value = new System.DateTime(2018, 5, 26, 20, 57, 16, 379);
            // 
            // txtcrscode
            // 
            this.txtcrscode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcrscode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcrscode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcrscode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcrscode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcrscode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcrscode.HintForeColor = System.Drawing.Color.Empty;
            this.txtcrscode.HintText = "";
            this.txtcrscode.isPassword = false;
            this.txtcrscode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcrscode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcrscode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcrscode.LineThickness = 3;
            this.txtcrscode.Location = new System.Drawing.Point(341, 48);
            this.txtcrscode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcrscode.MaxLength = 32767;
            this.txtcrscode.Name = "txtcrscode";
            this.txtcrscode.Size = new System.Drawing.Size(262, 33);
            this.txtcrscode.TabIndex = 16;
            this.txtcrscode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcrsfee
            // 
            this.txtcrsfee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcrsfee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcrsfee.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcrsfee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcrsfee.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcrsfee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcrsfee.HintForeColor = System.Drawing.Color.Empty;
            this.txtcrsfee.HintText = "";
            this.txtcrsfee.isPassword = false;
            this.txtcrsfee.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcrsfee.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcrsfee.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcrsfee.LineThickness = 3;
            this.txtcrsfee.Location = new System.Drawing.Point(341, 189);
            this.txtcrsfee.Margin = new System.Windows.Forms.Padding(4);
            this.txtcrsfee.MaxLength = 32767;
            this.txtcrsfee.Name = "txtcrsfee";
            this.txtcrsfee.Size = new System.Drawing.Size(262, 33);
            this.txtcrsfee.TabIndex = 18;
            this.txtcrsfee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcrstchr
            // 
            this.txtcrstchr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcrstchr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcrstchr.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcrstchr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcrstchr.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcrstchr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcrstchr.HintForeColor = System.Drawing.Color.Empty;
            this.txtcrstchr.HintText = "";
            this.txtcrstchr.isPassword = false;
            this.txtcrstchr.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcrstchr.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcrstchr.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcrstchr.LineThickness = 3;
            this.txtcrstchr.Location = new System.Drawing.Point(341, 136);
            this.txtcrstchr.Margin = new System.Windows.Forms.Padding(4);
            this.txtcrstchr.MaxLength = 32767;
            this.txtcrstchr.Name = "txtcrstchr";
            this.txtcrstchr.Size = new System.Drawing.Size(262, 33);
            this.txtcrstchr.TabIndex = 19;
            this.txtcrstchr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcrstitle
            // 
            this.txtcrstitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcrstitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcrstitle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcrstitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcrstitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcrstitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcrstitle.HintForeColor = System.Drawing.Color.Empty;
            this.txtcrstitle.HintText = "";
            this.txtcrstitle.isPassword = false;
            this.txtcrstitle.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcrstitle.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcrstitle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcrstitle.LineThickness = 3;
            this.txtcrstitle.Location = new System.Drawing.Point(341, 93);
            this.txtcrstitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtcrstitle.MaxLength = 32767;
            this.txtcrstitle.Name = "txtcrstitle";
            this.txtcrstitle.Size = new System.Drawing.Size(262, 33);
            this.txtcrstitle.TabIndex = 20;
            this.txtcrstitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(140, 59);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(131, 22);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Course Code";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(140, 249);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(103, 22);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Start Date";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(140, 189);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(112, 22);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "Course Fee";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(140, 147);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(154, 22);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "Course Teacher";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(140, 104);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(112, 22);
            this.bunifuCustomLabel5.TabIndex = 25;
            this.bunifuCustomLabel5.Text = "Course Title";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(140, 305);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(96, 22);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "End Date";
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
            this.bunifuThinButton21.ButtonText = "Add Course";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(623, 347);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(162, 41);
            this.bunifuThinButton21.TabIndex = 27;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(197, 33);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(392, 23);
            this.bunifuSeparator1.TabIndex = 28;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // addcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 390);
            this.Controls.Add(this.panel1);
            this.Name = "addcourse";
            this.Text = "addcourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker EnddatedateTimePicker2;
        private Bunifu.Framework.UI.BunifuDatepicker startdatedateTimePicker1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcrstitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcrstchr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcrsfee;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcrscode;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}