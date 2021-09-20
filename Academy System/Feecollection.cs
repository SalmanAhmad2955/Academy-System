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
    public partial class StudentsReport : Form
    {
        Student fee = new Student();
        public StudentsReport()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            label7.Text = a.Totalstudents().ToString();
            label8.Text = a.male().ToString();
            label9.Text = a.female().ToString();
            label10.Text = a.feedeposit().ToString();
            label11.Text = a.remainingdues().ToString();
            //textBox1.Text = a.Csharp().ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            this.Hide();
            a.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            label7.Text = a.Totalstudents().ToString();
            label8.Text = a.male().ToString();
            label9.Text = a.female().ToString();
            label10.Text = a.feedeposit().ToString();
            label11.Text = a.remainingdues().ToString();
            //textBox1.Text = a.Csharp().ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            Students a = new Students();
            this.Hide();
            a.Show();
        }
    }
}
