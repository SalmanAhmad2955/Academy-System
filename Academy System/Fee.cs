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
    public partial class Fee : Form
    {
        public Fee()
        {
            InitializeComponent();
        }

        private void Fee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            Fee b = new Fee();
            this.Hide();
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fee a = new Fee();
            Form1 b = new Form1();
            this.Hide();
            b.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teachers a = new Teachers();
            Fee b = new Fee();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Courses a = new Courses();
            Fee b = new Fee();
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            Fee b = new Fee();
            this.Hide();
            a.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Courses a = new Courses();
            Fee b = new Fee();
            this.Hide();
            a.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Teachers a = new Teachers();
            Fee b = new Fee();
            this.Hide();
            a.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Fee a = new Fee();
            Form1 b = new Form1();
            this.Hide();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
