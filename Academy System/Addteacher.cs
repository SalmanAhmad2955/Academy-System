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
    public partial class Addteacher : Form
    {
        public Addteacher()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                int tsalary = 0, no;
                string coursesb = null;
                int count = 0;
                Teacher teachers = new Teacher();
                teachers.TeacherId = int.Parse(txtteacherid.Text);
                teachers.TeacherName = txttchrname.Text;
                teachers.Gender = gendertchrcomboBox1.SelectedItem.ToString();
                teachers.Qualification = txtqualifiction.Text;
                teachers.Noofcrses = int.Parse(comboBox1.SelectedItem.ToString());
                no = int.Parse((teachers.Noofcrses).ToString());
                if (checkBox1.Checked)
                {
                    checkBox1.Text=
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (checkBox2.Checked)
                {

                    coursesb = coursesb + " ,PHP";
                    count++;
                    tsalary = tsalary + 8000;
                }
                if (checkBox3.Checked)
                {
                    coursesb = coursesb + " ,.NET";
                    count++;
                    tsalary = tsalary + 11000;
                }
                if (checkBox4.Checked)
                {
                    coursesb = coursesb + " ,Networking";
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (checkBox5.Checked)
                {
                    coursesb = coursesb + " ,Web Development";
                    count++;
                    tsalary = tsalary + 9000;
                }
                /*if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
                {
                    txtsalary.Text = "Rs." + tsalary;
                }*/
                /*if (count > no)
                {
                    MessageBox.Show("You selected more than number of subjects you asked! try again");
                }
                if (count < no)
                {
                    MessageBox.Show("You selected less than number of subjects you asked! try again");
                }
                teachers.Courses = coursesb;
                teachers.Salary = int.Parse(txtsalary.Text);
                    teachers.JoiningDate = joiningdateTimePicker1.Value.ToShortDateString();
                    teachers.Email = txtemail.Text;
                    teachers.Phone = txtphone.Text;
                if (count == no)
                {
                    if (new Teachersdb().Insert(teachers) > 0)
                    {
                        MessageBox.Show("Teacher added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Teacher");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }*/
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
                    }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /*try
            {
                int tsalary = 0, no;
                string coursesb = null;
                int count = 0;
                Teacher teachers = new Teacher();
                teachers.TeacherId = int.Parse(txtteacherid.Text);
                teachers.TeacherName = txttchrname.Text;
                teachers.Gender = gendertchrcomboBox1.SelectedItem.ToString();
                teachers.Qualification = txtqualifiction.Text;
                teachers.Noofcrses = int.Parse(comboBox1.SelectedItem.ToString());
                no = int.Parse((teachers.Noofcrses).ToString());
                if (checkBox1.Checked)
                {
                    checkBox1.Text=
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (checkBox2.Checked)
                {

                    coursesb = coursesb + " ,PHP";
                    count++;
                    tsalary = tsalary + 8000;
                }
                if (checkBox3.Checked)
                {
                    coursesb = coursesb + " ,.NET";
                    count++;
                    tsalary = tsalary + 11000;
                }
                if (checkBox4.Checked)
                {
                    coursesb = coursesb + " ,Networking";
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (checkBox5.Checked)
                {
                    coursesb = coursesb + " ,Web Development";
                    count++;
                    tsalary = tsalary + 9000;
                }
                /*if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
                {
                    txtsalary.Text = "Rs." + tsalary;
                }*/
            /*if (count > no)
            {
                MessageBox.Show("You selected more than number of subjects you asked! try again");
            }
            if (count < no)
            {
                MessageBox.Show("You selected less than number of subjects you asked! try again");
            }
            teachers.Courses = coursesb;
            teachers.Salary = int.Parse(txtsalary.Text);
                teachers.JoiningDate = joiningdateTimePicker1.Value.ToShortDateString();
                teachers.Email = txtemail.Text;
                teachers.Phone = txtphone.Text;
            if (count == no)
            {
                if (new Teachersdb().Insert(teachers) > 0)
                {
                    MessageBox.Show("Teacher added Successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add Teacher");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }*/
        }
    }
}
