using System;
using System.Windows.Forms;

namespace DAILYHABITTRACKERAPP
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnaddhabit_Click(object sender, EventArgs e)
        {
            AddHabitForm form = new AddHabitForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Progress feature coming soon!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loginform login = new Loginform();
            login.Show();
            this.Hide();
        }

        private void btnviewhabit_Click(object sender, EventArgs e)
        {
            AddHabitForm form = new AddHabitForm();
            form.Show();
        }
    }
}
   