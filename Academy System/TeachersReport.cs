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
    public partial class TeachersReport : Form
    {
        public TeachersReport()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teachers a = new Teachers();
            label9.Text = a.TotalSalary().ToString();
            label6.Text = a.TotalTeachers().ToString();
            label8.Text = a.male().ToString();
            label7.Text = a.female().ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Teachers a = new Teachers();
            label9.Text = a.TotalSalary().ToString();
            label6.Text = a.TotalTeachers().ToString();
            label8.Text = a.male().ToString();
            label7.Text = a.female().ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
