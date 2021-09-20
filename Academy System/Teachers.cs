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
    public partial class Teachers : Form
    {
        Teacher model = new Teacher();
        public Teachers()
        {
            InitializeComponent();
           TutionCenterEntities db = new TutionCenterEntities();
            var data = (from d in db.Teachers select d);
            dataGridView1.DataSource = data.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students a = new Students();
            a.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses a = new Courses();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addteacher a = new Addteacher();
            a.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                model.TeacherId = int.Parse(txtteacherid.Text.Trim());
                model.TeacherName = txttchrname.Text.Trim();
                model.Qualification = txtqualifiction.Text.Trim();
                model.Salary = int.Parse(txtsalary.Text.Trim());
                model.Course1 = comboBox1.Text.Trim();
                model.Course2 = comboBox2.Text.Trim();
                model.Course3 = comboBox3.Text.Trim();
                model.Course4 = comboBox4.Text.Trim();
                model.Course5 = comboBox5.Text.Trim();
                model.Email = txtemail.Text.Trim();
                model.Phone = txtphone.Text.Trim();
                string g = gendertchrcomboBox1.SelectedItem.ToString();
                model.Gender = g.Trim();
                model.JoiningDate = joiningdateTimePicker1.Text.Trim();
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Record Updated Successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fee a = new Fee();
            Teachers b = new Teachers();
            a.Show();
            this.Hide();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.TeacherId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TeacherId"].Value);
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    model = db.Teachers.Where(x => x.TeacherId == model.TeacherId).FirstOrDefault();
                    txttchrname.Text = model.TeacherName;
                    txtteacherid.Text = model.TeacherId.ToString();
                    Noofcrses.Text = model.Noofcrses.ToString();
                    // m = int.Parse(txtStudentid.Text);
                    //m= Convert.ToInt32(model.StudentId);
                    gendertchrcomboBox1.Text = model.Gender;
                    txtphone.Text = model.Phone;
                    txtemail.Text = model.Email;
                    txtqualifiction.Text = model.Qualification;
                    txtsalary.Text = model.Salary.ToString();
                    joiningdateTimePicker1.Text = model.JoiningDate;
                        comboBox1.Text = model.Course1;
                        comboBox2.Text = model.Course2;
                        comboBox3.Text = model.Course3;
                        comboBox4.Text = model.Course4;
                        comboBox5.Text = model.Course5;
                    // string s = checkBox1.Text + checkBox2.Text + checkBox3.Text + checkBox4.Text + checkBox5.Text;
                    // int n = int.Parse(Numberofcrses.Text);
                    //n= Convert.ToInt32(model.Tot_courses);


                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int tsalary = 0, no;
                //string coursesb = null;
                int count = 0;
                Teacher teachers = new Teacher();
                teachers.TeacherId = int.Parse(txtteacherid.Text);
                teachers.TeacherName = txttchrname.Text;
                teachers.Gender = gendertchrcomboBox1.SelectedItem.ToString();
                teachers.Qualification = txtqualifiction.Text;
                teachers.Noofcrses = int.Parse(Noofcrses.SelectedItem.ToString());
                no = int.Parse((teachers.Noofcrses).ToString());
                if (comboBox1.Text == "None")
                {
                    teachers.Course1 = comboBox1.Text;
                }
                if (comboBox1.Text != "None")
                {
                    teachers.Course1 = comboBox1.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox2.Text == "None")
                {
                    teachers.Course2 = comboBox2.Text;
                }
                if (comboBox2.Text != "None")
                {
                    teachers.Course2 = comboBox2.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox3.Text == "None")
                {
                    teachers.Course3 = comboBox3.Text;
                }
                if (comboBox3.Text != "None")
                {
                    teachers.Course3 = comboBox3.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox4.Text == "None")
                {
                    teachers.Course4 = comboBox4.Text;
                }
                if (comboBox4.Text != "None")
                {
                    teachers.Course4 = comboBox4.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox5.Text == "None")
                {
                    teachers.Course5 = comboBox5.Text;
                }
                if (comboBox5.Text != "None")
                {
                    teachers.Course5 = comboBox5.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                /*if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
                {
                    txtsalary.Text = "Rs." + tsalary;
                }*/
                if (count > no)
                {
                    MessageBox.Show("You selected more than number of subjects you asked! try again");
                    return;
                }
                if (count < no)
                {
                    MessageBox.Show("You selected less than number of subjects you asked! try again");
                    return;
                }
                else
                {
                    //teachers.Courses = coursesb;
                    teachers.Salary = int.Parse(txtsalary.Text);
                    teachers.JoiningDate = joiningdateTimePicker1.Value.ToShortDateString();
                    teachers.Email = txtemail.Text;
                    teachers.Phone = txtphone.Text;

                    if (comboBox1.Text == comboBox2.Text || comboBox1.Text == comboBox3.Text || comboBox1.Text == comboBox4.Text || comboBox1.Text == comboBox5.Text)
                    {
                        if (comboBox1.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox2.Text == comboBox1.Text || comboBox2.Text == comboBox3.Text || comboBox2.Text == comboBox4.Text || comboBox2.Text == comboBox5.Text)
                    {
                        if (comboBox2.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox3.Text == comboBox1.Text || comboBox3.Text == comboBox2.Text || comboBox3.Text == comboBox4.Text || comboBox3.Text == comboBox5.Text)
                    {
                        if (comboBox3.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox4.Text == comboBox1.Text || comboBox4.Text == comboBox3.Text || comboBox4.Text == comboBox2.Text || comboBox4.Text == comboBox5.Text)
                    {
                        if (comboBox4.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox5.Text == comboBox2.Text || comboBox5.Text == comboBox3.Text || comboBox5.Text == comboBox4.Text || comboBox5.Text == comboBox1.Text)
                    {
                        if (comboBox5.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
            }
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
            }
        }
        public int TotalSalary()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value);
            }
            return sum;
        }
        public int TotalTeachers()
        {
            int totalteachers = dataGridView1.RowCount;
            return totalteachers;
        }
        public int male()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Male")
                {
                    count++;
                }
            }
            return count;
        }
        public int female()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Female")
                {
                    count++;
                }
            }
            return count;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Teachers.Attach(model);
                        db.Teachers.Remove(model);
                        db.SaveChanges();
                        MessageBox.Show("Record was deleted successfully");
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TeachersReport ab = new TeachersReport();
            ab.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TeachersReport ab = new TeachersReport();
            ab.Show();
        }

        private void joiningdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtphone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                int tsalary = 0, no;
                //string coursesb = null;
                int count = 0;
                Teacher teachers = new Teacher();
                teachers.TeacherId = int.Parse(txtteacherid.Text);
                teachers.TeacherName = txttchrname.Text;
                teachers.Gender = gendertchrcomboBox1.SelectedItem.ToString();
                teachers.Qualification = txtqualifiction.Text;
                teachers.Noofcrses = int.Parse(Noofcrses.SelectedItem.ToString());
                no = int.Parse((teachers.Noofcrses).ToString());
                if (comboBox1.Text == "None")
                {
                    teachers.Course1 = comboBox1.Text;
                }
                if (comboBox1.Text != "None")
                {
                    teachers.Course1 = comboBox1.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox2.Text == "None")
                {
                    teachers.Course2 = comboBox2.Text;
                }
                if (comboBox2.Text != "None")
                {
                    teachers.Course2 = comboBox2.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox3.Text == "None")
                {
                    teachers.Course3 = comboBox3.Text;
                }
                if (comboBox3.Text != "None")
                {
                    teachers.Course3 = comboBox3.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox4.Text == "None")
                {
                    teachers.Course4 = comboBox4.Text;
                }
                if (comboBox4.Text != "None")
                {
                    teachers.Course4 = comboBox4.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                if (comboBox5.Text == "None")
                {
                    teachers.Course5 = comboBox5.Text;
                }
                if (comboBox5.Text != "None")
                {
                    teachers.Course5 = comboBox5.Text;
                    count++;
                    tsalary = tsalary + 10000;
                }
                /*if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
                {
                    txtsalary.Text = "Rs." + tsalary;
                }*/
                if (count > no)
                {
                    MessageBox.Show("You selected more than number of subjects you asked! try again");
                    return;
                }
                if (count < no)
                {
                    MessageBox.Show("You selected less than number of subjects you asked! try again");
                    return;
                }
                else
                {
                    //teachers.Courses = coursesb;
                    teachers.Salary = int.Parse(txtsalary.Text);
                    teachers.JoiningDate = joiningdateTimePicker1.Value.ToShortDateString();
                    teachers.Email = txtemail.Text;
                    teachers.Phone = txtphone.Text;

                    if (comboBox1.Text == comboBox2.Text || comboBox1.Text == comboBox3.Text || comboBox1.Text == comboBox4.Text || comboBox1.Text == comboBox5.Text)
                    {
                        if (comboBox1.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox2.Text == comboBox1.Text || comboBox2.Text == comboBox3.Text || comboBox2.Text == comboBox4.Text || comboBox2.Text == comboBox5.Text)
                    {
                        if (comboBox2.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox3.Text == comboBox1.Text || comboBox3.Text == comboBox2.Text || comboBox3.Text == comboBox4.Text || comboBox3.Text == comboBox5.Text)
                    {
                        if (comboBox3.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox4.Text == comboBox1.Text || comboBox4.Text == comboBox3.Text || comboBox4.Text == comboBox2.Text || comboBox4.Text == comboBox5.Text)
                    {
                        if (comboBox4.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                    if (comboBox5.Text == comboBox2.Text || comboBox5.Text == comboBox3.Text || comboBox5.Text == comboBox4.Text || comboBox5.Text == comboBox1.Text)
                    {
                        if (comboBox5.Text != "None")
                        {
                            Students a = new Students();
                            MessageBox.Show("You cannot select one course two time try again");
                            return;
                        }
                    }
                }
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
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                model.TeacherId = int.Parse(txtteacherid.Text.Trim());
                model.TeacherName = txttchrname.Text.Trim();
                model.Qualification = txtqualifiction.Text.Trim();
                model.Salary = int.Parse(txtsalary.Text.Trim());
                model.Course1 = comboBox1.Text.Trim();
                model.Course2 = comboBox2.Text.Trim();
                model.Course3 = comboBox3.Text.Trim();
                model.Course4 = comboBox4.Text.Trim();
                model.Course5 = comboBox5.Text.Trim();
                model.Email = txtemail.Text.Trim();
                model.Phone = txtphone.Text.Trim();
                string g = gendertchrcomboBox1.SelectedItem.ToString();
                model.Gender = g.Trim();
                model.JoiningDate = joiningdateTimePicker1.Text.Trim();
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Record Updated Successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Teachers.Attach(model);
                        db.Teachers.Remove(model);
                        db.SaveChanges();
                        MessageBox.Show("Record was deleted successfully");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
