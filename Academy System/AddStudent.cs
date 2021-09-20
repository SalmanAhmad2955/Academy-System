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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string coursesb = "";
            //int count = 0;
           /* try
            {
                Student students = new Student();
                students.StudentId = int.Parse(txtStudentid.Text);
                students.StudentName = txtStudentname.Text;
                students.Tot_courses = int.Parse(Numberofcrses.SelectedItem.ToString());
                int no = int.Parse(Numberofcrses.SelectedItem.ToString());
                students.FatherName = txtFathername.Text;
                students.Gender = GendercomboBox.SelectedItem.ToString();
                int fee = 0;
                int count = 0;
                string coursesb = null;
                 if (checkBox1.Checked)
                   {
                       
                       count++;
                    fee = fee + 4000;
                   }
                   if(checkBox2.Checked)
                   {
                       
                       coursesb = coursesb + " ,PHP";
                       count++;
                    fee = fee + 5000;
                   }
                   if (checkBox3.Checked)
                   {
                    coursesb = coursesb + " ,.NET";
                    count++;
                    fee = fee + 5500;
                   }
                   if (checkBox4.Checked)
                   {
                    coursesb = coursesb + " ,Networking";
                    count++;
                    fee = fee + 3000;
                   }
                   if (checkBox5.Checked)
                   {
                    coursesb = coursesb + " ,Web Development";
                    count++;
                    fee = fee + 3000;
                   }
                   if(count>no)
                   {
                       MessageBox.Show("You selected more than number of subjects you asked! try again");
                   }
                  else if(count<no)
                   {
                       MessageBox.Show("You selected less than number of subjects you asked! try again");
                   }
                else
                {
                    
                    //students.Course = coursesb;
                    // students.Course = txtcourse.Text;
                    students.Dateofbirth = DObdateTimePicker1.Value.ToShortDateString();
                    students.StartDate = startdatedateTimePicker2.Value.ToShortDateString();
                    students.EndDate = EnddatedateTimePicker3.Value.ToShortDateString();
                    students.Email = txtemail.Text;
                    students.Phone = txtphone.Text;
                    if (new Studentsdb().Insert(students) > 0)
                    {
                        MessageBox.Show("Student added Successfully!");
                        totalfee.Text = "Rs."+fee.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }*/

        }

        private void NewMethod(Student students)
        {
            //students.Course = checkBox1.Checked = true;
        }

        private void txtStudentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numberofcrses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_OnChange(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStudentid_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
