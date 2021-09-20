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
    public partial class Students : Form
    {
        int sum = 0;
        Student model = new Student();
     TutionCenterEntities Myobj = new TutionCenterEntities();
        public Students()
        {
            InitializeComponent();
            TutionCenterEntities db = new TutionCenterEntities();
            var data = (from d in db.Students select d);
            dataGridView1.DataSource = data.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fee a = new Fee();
            Students b = new Students();
            a.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                model.StudentId = int.Parse(txtStudentid.Text.Trim());
                model.StudentName = txtStudentname.Text.Trim();
                model.FatherName = txtFathername.Text.Trim();
                model.Dateofbirth = DObdateTimePicker1.Text.Trim();
                model.Course1 = comboBox1.Text.Trim();
                model.Course2 = comboBox2.Text.Trim();
                model.Course3 = comboBox3.Text.Trim();
                model.Course4 = comboBox4.Text.Trim();
                model.Course5 = comboBox5.Text.Trim();
                model.Email = txtemail.Text.Trim();
                model.Phone = txtphone.Text.Trim();
                string g = GendercomboBox.SelectedItem.ToString();
                model.Gender = g.Trim();
                model.StartDate = startdatedateTimePicker2.Text.Trim();
                model.EndDate = EnddatedateTimePicker3.Text.Trim();
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    // dataGridView1.Refresh();
                    MessageBox.Show("Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers a = new Teachers();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses a = new Courses();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DbAccess db = new DbAccess();
            db.SearchByName(textBox1.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TutionCenterEntities db = new TutionCenterEntities();
            var data = (from d in db.Students select d);
            dataGridView1.DataSource = data.ToList();
        }

        private void GendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.StudentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StudentId"].Value);
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    model = db.Students.Where(x => x.StudentId == model.StudentId).FirstOrDefault();
                    txtStudentname.Text = model.StudentName;
                    txtStudentid.Text = model.StudentId.ToString();
                    Numberofcrses.Text = model.Tot_courses.ToString();
                    // m = int.Parse(txtStudentid.Text);
                    //m= Convert.ToInt32(model.StudentId);
                    GendercomboBox.Text = model.Gender;
                    txtFathername.Text = model.FatherName;
                    txtphone.Text = model.Phone;
                    txtemail.Text = model.Email;
                    DObdateTimePicker1.Text = model.Dateofbirth;
                    txtremainingdues.Text = model.RemainingDues.ToString();
                    lblfeestatus.Text = model.FeeStatus;
                    startdatedateTimePicker2.Text = model.StartDate;
                    EnddatedateTimePicker3.Text = model.EndDate;
                    comboBox1.Text = model.Course1;
                    comboBox2.Text = model.Course2;
                    comboBox3.Text = model.Course3;
                    comboBox4.Text = model.Course4;
                    comboBox5.Text = model.Course5;
                    totfee.Text = model.TotalFee.ToString();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string coursesb = "";
            //int count = 0;
            try
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
                if (comboBox1.Text == "None" || comboBox1.Text == " ")
                {
                    students.Course1 = "None";
                }
                if (comboBox1.Text != "None")
                {
                    students.Course1 = comboBox1.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (comboBox2.Text == "None" || comboBox1.Text == "")
                {
                    students.Course2 = "None";
                }
                if (comboBox2.Text != "None")
                {
                    students.Course2 = comboBox2.Text;
                    count++;
                    fee = fee + 5000;
                }
                if (comboBox3.Text == "None" || comboBox3.Text == "")
                {
                    students.Course3 = "None";
                }
                if (comboBox3.Text != "None")
                {
                    students.Course3 = comboBox3.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (comboBox4.Text == "None" || comboBox4.Text == "")
                {
                    students.Course4 = "None";
                }
                if (comboBox4.Text != "None")
                {
                    students.Course4 = comboBox4.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (comboBox5.Text == "None" || comboBox5.Text == "")
                {
                    students.Course5 = "None";
                }
                if (comboBox5.Text != "None")
                {
                    students.Course5 = comboBox5.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (count > no)
                {
                    MessageBox.Show("You selected more than number of subjects you asked! try again");
                    return;
                }
                else if (count < no)
                {
                    MessageBox.Show("You selected less than number of subjects you asked! try again");
                    return;
                }
                else
                {
                    // students.Course = txtcourse.Text;
                    students.Dateofbirth = DObdateTimePicker1.Value.ToShortDateString();
                    students.StartDate = startdatedateTimePicker2.Value.ToShortDateString();
                    students.EndDate = EnddatedateTimePicker3.Value.ToShortDateString();
                    students.Email = txtemail.Text;
                    students.Phone = txtphone.Text;
                    students.TotalFee = fee;
                    students.RemainingDues = students.TotalFee;
                    txtremainingdues.Text = (students.RemainingDues.ToString());
                    if (students.RemainingDues == students.TotalFee)
                    {
                        students.FeeStatus = "Not Deposit";
                    }
                    else if (students.RemainingDues < students.TotalFee && students.RemainingDues > 0)
                    {
                        students.FeeStatus = "Fee deposit but not full";
                    }
                    else if (students.RemainingDues == 0)
                    {
                        students.FeeStatus = "Fee Deposit";
                    }

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
                if (new Studentsdb().Insert(students) > 0)
                {
                    MessageBox.Show("Student added Successfully!");
                    totfee.Text = "Rs." + fee.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to add student");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Students.Attach(model);
                    db.Students.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Record was deleted successfully");
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            if (int.Parse(AmountPaid.Text) > int.Parse(txtremainingdues.Text) && count == 0)
            {
                MessageBox.Show("You entered amount more than remaining dues please try again!");
                count++;
            }
            if (int.Parse(AmountPaid.Text) == int.Parse(txtremainingdues.Text) && count == 0)
            {
                model.RemainingDues = model.RemainingDues - int.Parse(AmountPaid.Text.Trim());
                model.FeeStatus = "Deposit";
                model.FeeSubmissionDate = feesubmitdateTimePicker1.Text;
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    // dataGridView1.Refresh();
                    MessageBox.Show("Fee submitted successfully");
                }
                txtremainingdues.Text = model.RemainingDues.ToString();
                lblfeestatus.Text = model.FeeStatus;
                count++;
                dataGridView1.Refresh();
                //MessageBox.Show("Fee collected successfully!");
            }
            if (int.Parse(AmountPaid.Text) == int.Parse(txtremainingdues.Text) / 2 && count == 0)
            {
                model.RemainingDues = model.RemainingDues - (model.RemainingDues / 2);
                model.FeeStatus = "1st Installment deposit";
                model.FeeSubmissionDate = feesubmitdateTimePicker1.Text;
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    // dataGridView1.Refresh();
                    MessageBox.Show("Fee installment collected successfully!");
                }
                txtremainingdues.Text = model.RemainingDues.ToString();
                lblfeestatus.Text = "1st Installment deposited";
                count++;
            }
            if (count == 0)
            {
                MessageBox.Show("Cannot submit it must be full or half of remaining dues!");
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            StudentsReport ab = new StudentsReport();
            ab.Show();
        }
        public int Csharp(){
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 6; j <= 10; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == ".NET")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int Java()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 6; j <= 10; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "Java")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int PHP()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 6; j <= 10; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "PHP")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int Networking()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 6; j <= 10; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "Networking")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int Web()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 6; j <= 10; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "WebDevelopment")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int Totalstudents()
        {
            int totalstudents = dataGridView1.RowCount;
            return totalstudents;
            /*for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value);
            }
            for (int i=0; i<dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString()== "Male")
                {
                    count++;
                }
            }
            return sum;*/
        }
        public int Totalfee()
        {
            sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value);
            }
            return sum;
        }
        public int male()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Male")
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
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Female")
                {
                    count++;
                }
            }
            return count;
        }
        public int feedeposit()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[15].Value.ToString() == "Deposit")
                {
                    count++;
                }
            }
            return count;
        }
        public int remainingdues()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[14].Value)>0)
                {
                    count++;
                }
            }
            return count;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void AmountPaid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //string coursesb = "";
            //int count = 0;
            try
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
                if (comboBox1.Text == "None" || comboBox1.Text == " ")
                {
                    students.Course1 = "None";
                }
                if (comboBox1.Text != "None")
                {
                    students.Course1 = comboBox1.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (comboBox2.Text == "None" || comboBox1.Text == "")
                {
                    students.Course2 = "None";
                }
                if (comboBox2.Text != "None")
                {
                    students.Course2 = comboBox2.Text;
                    count++;
                    fee = fee + 5000;
                }
                if (comboBox3.Text == "None" || comboBox3.Text == "")
                {
                    students.Course3 = "None";
                }
                if (comboBox3.Text != "None")
                {
                    students.Course3 = comboBox3.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (comboBox4.Text == "None" || comboBox4.Text == "")
                {
                    students.Course4 = "None";
                }
                if (comboBox4.Text != "None")
                {
                    students.Course4 = comboBox4.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (comboBox5.Text == "None" || comboBox5.Text == "")
                {
                    students.Course5 = "None";
                }
                if (comboBox5.Text != "None")
                {
                    students.Course5 = comboBox5.Text;
                    count++;
                    fee = fee + 4000;
                }
                if (count > no)
                {
                    MessageBox.Show("You selected more than number of subjects you asked! try again");
                    return;
                }
                else if (count < no)
                {
                    MessageBox.Show("You selected less than number of subjects you asked! try again");
                    return;
                }
                else
                {
                    // students.Course = txtcourse.Text;
                    students.Dateofbirth = DObdateTimePicker1.Value.ToShortDateString();
                    students.StartDate = startdatedateTimePicker2.Value.ToShortDateString();
                    students.EndDate = EnddatedateTimePicker3.Value.ToShortDateString();
                    students.Email = txtemail.Text;
                    students.Phone = txtphone.Text;
                    students.TotalFee = fee;
                    students.RemainingDues = students.TotalFee;
                    txtremainingdues.Text = (students.RemainingDues.ToString());
                    if (students.RemainingDues == students.TotalFee)
                    {
                        students.FeeStatus = "Not Deposit";
                    }
                    else if (students.RemainingDues < students.TotalFee && students.RemainingDues > 0)
                    {
                        students.FeeStatus = "Fee deposit but not full";
                    }
                    else if (students.RemainingDues == 0)
                    {
                        students.FeeStatus = "Fee Deposit";
                    }

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
                if (new Studentsdb().Insert(students) > 0)
                {
                    MessageBox.Show("Student added Successfully!");
                    totfee.Text = "Rs." + fee.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to add student");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                model.StudentId = int.Parse(txtStudentid.Text.Trim());
                model.StudentName = txtStudentname.Text.Trim();
                model.FatherName = txtFathername.Text.Trim();
                model.Dateofbirth = DObdateTimePicker1.Text.Trim();
                model.Course1 = comboBox1.Text.Trim();
                model.Course2 = comboBox2.Text.Trim();
                model.Course3 = comboBox3.Text.Trim();
                model.Course4 = comboBox4.Text.Trim();
                model.Course5 = comboBox5.Text.Trim();
                model.Email = txtemail.Text.Trim();
                model.Phone = txtphone.Text.Trim();
                string g = GendercomboBox.SelectedItem.ToString();
                model.Gender = g.Trim();
                model.StartDate = startdatedateTimePicker2.Text.Trim();
                model.EndDate = EnddatedateTimePicker3.Text.Trim();
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    // dataGridView1.Refresh();
                    MessageBox.Show("Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Students.Attach(model);
                    db.Students.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Record was deleted successfully");
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (int.Parse(AmountPaid.Text) > int.Parse(txtremainingdues.Text) && count == 0)
            {
                MessageBox.Show("You entered amount more than remaining dues please try again!");
                count++;
            }
            if (int.Parse(AmountPaid.Text) == int.Parse(txtremainingdues.Text) && count == 0)
            {
                model.RemainingDues = model.RemainingDues - int.Parse(AmountPaid.Text.Trim());
                model.FeeStatus = "Deposit";
                model.FeeSubmissionDate = feesubmitdateTimePicker1.Text;
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    // dataGridView1.Refresh();
                    MessageBox.Show("Fee submitted successfully");
                }
                txtremainingdues.Text = model.RemainingDues.ToString();
                lblfeestatus.Text = model.FeeStatus;
                count++;
                dataGridView1.Refresh();
                //MessageBox.Show("Fee collected successfully!");
            }
            if (int.Parse(AmountPaid.Text) == int.Parse(txtremainingdues.Text) / 2 && count == 0)
            {
                model.RemainingDues = model.RemainingDues - (model.RemainingDues / 2);
                model.FeeStatus = "1st Installment deposit";
                model.FeeSubmissionDate = feesubmitdateTimePicker1.Text;
                using (TutionCenterEntities db = new TutionCenterEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    // dataGridView1.Refresh();
                    MessageBox.Show("Fee installment collected successfully!");
                }
                txtremainingdues.Text = model.RemainingDues.ToString();
                lblfeestatus.Text = "1st Installment deposited";
                count++;
            }
            if (count == 0)
            {
                MessageBox.Show("Cannot submit it must be full or half of remaining dues!");
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            StudentsReport ab = new StudentsReport();
            ab.Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
