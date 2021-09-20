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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-NSF3BUS\\SQLEXPRESS01; database=AcademySystem;integrated security=SSPI";
                SqlCommand cmd = new SqlCommand("select *from Courses", con);
                con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                dataGridView1.DataSource = source;
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers a = new Teachers();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students a = new Students();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fee a = new Fee();
            Courses b = new Courses();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcourse a = new addcourse();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-NSF3BUS\\SQLEXPRESS01; database=AcademySystem;integrated security=SSPI";
                SqlCommand cmd = new SqlCommand("select *from Courses", con);
                con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                dataGridView1.DataSource = source;
                dataGridView1.Refresh();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Courses a = new Courses();
            this.Hide();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dataGridView1.Columns.Add(Deletelink);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HomePage a = new HomePage();
            this.Hide();
            a.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-NSF3BUS\\SQLEXPRESS01; database=AcademySystem;integrated security=SSPI";
                SqlCommand cmd = new SqlCommand("select *from Courses", con);
                con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                dataGridView1.DataSource = source;
                dataGridView1.Refresh();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcourse a = new addcourse();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dataGridView1.Columns.Add(Deletelink);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            HomePage a = new HomePage();
            this.Hide();
            a.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students a = new Students();
            a.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers a = new Teachers();
            a.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Fee a = new Fee();
            Courses b = new Courses();
            a.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            Courses a = new Courses();
            this.Hide();
            a.Show();
        }
    }
}
