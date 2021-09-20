using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            SignupPanel.Visible = false;
            Loginpanel.Visible = true;
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            Loginpanel.Visible = true;
            SignupPanel.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Forgottenpswrdlnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loginpanel.Visible = true;
            Resetpswrdpanel.Visible = true;
            RpPanel.Visible = false;
        }

        private void ResetPasswordlnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Resetpswrdpanel.Visible = true;
        }

        private void Loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginpanelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Admin a = new Admin();
                a.Id = int.Parse(txtUserid.Text);
                a.Name = txtUsername.Text;
                a.Password = txtPassword.Text;
                if (new DbAccess().Login(a.Name, a.Password) > 0)
                {
                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect user name id or password try again!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            /*try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-NSF3BUS\\SQLEXPRESS01; database=AcademySystem;integrated security=SSPI";
                SqlCommand cmd = new SqlCommand("select *from Admin WHERE Id=@id and Name=@name and Password=@password", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                cmd.Parameters.AddWithValue("@name", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                SqlDataReader DR = cmd.ExecuteReader();
                if(DR.HasRows==true)
                {
                    MessageBox.Show("Login Successfully!");
                    this.Hide();
                    HomePage a = new HomePage();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect user name id or password try again!");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin();
                admin.Id = int.Parse(Userid.Text);
                admin.Name = Username.Text;
                admin.Password = Password.Text;
                String confirmpasswrd = ConfirmPassword.Text;
                if (confirmpasswrd == admin.Password)
                {
                    if (new DbAccess().Insert(admin) > 0)
                    {
                        MessageBox.Show("Account Created Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed Account cannot be created");
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match try again!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void SignupPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RpResetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Admin a = new Admin();
                a.Name = Rpusername.Text;
                a.Password = Rpnewpswrd.Text;
                if (Rpnewpswrd.Text == Rpconfrmpswrd.Text)
                {
                    if (new DbAccess().Update(a.Name, a.Password) > 0)
                    {
                        MessageBox.Show("Password changed Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Head_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            SignupPanel.Visible = false;
            Loginpanel.Visible = true;
        }

        private void Signupbtn_Click_1(object sender, EventArgs e)
        {

            Loginpanel.Visible = false;
            SignupPanel.Visible = true;
        }

        private void Userid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
            /*        try
            {
                Admin a = new Admin();
                a.Id = int.Parse(txtUserid.Text);
                a.Name = txtUsername.Text;
                a.Password = txtPassword.Text;
                if (new DbAccess().Login(a.Name, a.Password) > 0)
                {
                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect user name id or password try again!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


    */






        }

        private void Loginbtn_Click_2(object sender, EventArgs e)
        {
            SignupPanel.Visible = false;
            Loginpanel.Visible = true;
        }

        private void Signupbtn_Click_2(object sender, EventArgs e)
        {

            Loginpanel.Visible = false;
            SignupPanel.Visible = true;
        }
    }
}
