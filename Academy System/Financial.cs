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
    public partial class Financial : Form
    {
        public Financial()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            Teachers b = new Teachers();
            int fee = a.Totalfee();
            label6.Text = fee.ToString();
            int salary = b.TotalSalary();
            label7.Text = salary.ToString();
            label8.Text = "35000";
            int others = int.Parse(label8.Text);
            if (fee >(salary+others))
            {
                int profit = fee - (salary + others);
                label9.Text = "Academy is running in profit of RS."+profit;
            }
            else if(fee<(salary+others))
            {
                int loss = (salary + others) - fee;
                label9.Text = "Academy is running in loss of RS." + loss;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Students a = new Students();
            Teachers b = new Teachers();
            int fee = a.Totalfee();
            label6.Text = fee.ToString();
            int salary = b.TotalSalary();
            label7.Text = salary.ToString();
            label8.Text = "35000";
            int others = int.Parse(label8.Text);
            if (fee > (salary + others))
            {
                int profit = fee - (salary + others);
                label9.Text = "Academy is running in profit of RS." + profit;
            }
            else if (fee < (salary + others))
            {
                int loss = (salary + others) - fee;
                label9.Text = "Academy is running in loss of RS." + loss;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }
    }
}
