using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy_System
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void FeesBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Studentsbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Coursesbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void dlttchrbtn_Click(object sender, EventArgs e)
        {

        }

        private void Deletestbtn_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentbtn_Click(object sender, EventArgs e)
        {
            AddStudent a = new AddStudent();
            a.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsReport a = new StudentsReport();
            a.Show();
        }

        private void addcrsbtn_Click(object sender, EventArgs e)
        {
            addcourse a = new addcourse();
            a.Show();
        }

        private void Dltcrsbtn_Click(object sender, EventArgs e)
        {
            deletecourse a = new deletecourse();
            a.Show();
        }

        private void addtchrbtn_Click(object sender, EventArgs e)
        {
            Addteacher a = new Addteacher();
            a.Show();
        }

        private void Studentsbtn_Click_1(object sender, EventArgs e)
        {
            Students a = new Students();
            this.Hide();
            a.Show();
        }

        private void TeachersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers a = new Teachers();
            a.Show();
        }

        private void Coursesbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Courses a = new Courses();
            a.Show();
        }

        private void FeesBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Financial a = new Financial();
            a.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            this.Hide();
            a.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Teachers a = new Teachers();
            a.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses a = new Courses();
            a.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Financial a = new Financial();
            a.Show();
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
