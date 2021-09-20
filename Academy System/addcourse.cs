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
    public partial class addcourse : Form
    {
        public addcourse()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {/*
            try
            {
                Cours courses = new Cours();
                courses.CourseCode =txtcrscode.Text;
                courses.CourseTitle = txtcrstitle.Text;
                courses.CourseFee = int.Parse(txtcrsfee.Text);
                courses.CourseTeacher = txtcrstchr.Text;
                courses.StartDate = startdatedateTimePicker1.Value.ToShortDateString();
                courses.EndDate = EnddatedateTimePicker2.Value.ToShortDateString();
                if(new Coursesdb().Insert(courses) > 0)
                {
    
                    MessageBox.Show("Course added successfuly");
                }
                else
                {
                    MessageBox.Show("Failed Course cannot be added");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }*/
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Cours courses = new Cours();
                courses.CourseCode = txtcrscode.Text;
                courses.CourseTitle = txtcrstitle.Text;
                courses.CourseFee = int.Parse(txtcrsfee.Text);
                courses.CourseTeacher = txtcrstchr.Text;
                courses.StartDate = startdatedateTimePicker1.Value.ToShortDateString();
                courses.EndDate = EnddatedateTimePicker2.Value.ToShortDateString();
                if (new Coursesdb().Insert(courses) > 0)
                {

                    MessageBox.Show("Course added successfuly");
                }
                else
                {
                    MessageBox.Show("Failed Course cannot be added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
