using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DAILYHABITTRACKERAPP
{
    public partial class AddHabitForm : Form
    {
        List<string> habits = new List<string>();

        public AddHabitForm()
        {
            InitializeComponent();
        }

        private void AddHabitForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHabitName.Text == "" || cmbCategory.Text == "")
            {
                MessageBox.Show("Enter habit name and category");
                return;
            }

            string habit = txtHabitName.Text + " - " + cmbCategory.Text;

            habits.Add(habit);
            lstHabits.Items.Add(habit);

            txtHabitName.Clear();
            cmbCategory.SelectedIndex = -1;

            MessageBox.Show("Habit Added Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedIndex >= 0)
            {
                lstHabits.Items.RemoveAt(lstHabits.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a habit to delete");
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete clicked");

            if (lstHabits.SelectedIndex >= 0)
            {
                int index = lstHabits.SelectedIndex;

                string completedHabit =
                    lstHabits.SelectedItem.ToString() + " - Completed";

                lstHabits.Items.RemoveAt(index);
                lstHabits.Items.Insert(index, completedHabit);
            }
            else
            {
                MessageBox.Show("Select a habit first");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}