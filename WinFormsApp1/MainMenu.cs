using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    //this code brings you to the main menu to see the other pages
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //this button will show if the user logs out
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }
        //each button will redirect the user to the different pages by the preference of the user
        private void pictureBoxOpeningHours_Click(object sender, EventArgs e)
        {

        }

        private void buttonPolicy_Click(object sender, EventArgs e)
        {
            Policies polices = new Policies();
            polices.Show();
            this.Hide();
        }

        private void buttonOpeningHours_Click(object sender, EventArgs e)
        {
            OpeningHours openinghour = new OpeningHours();
            openinghour.Show();
            this.Hide();
        }

        // private void pictureEmployee_Click(object sender, EventArgs e)
        // {

        // }
        //this redirects the users to the following pages,
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.Show();
            this.Hide();
        }

        private void buttonShiftTimes_Click(object sender, EventArgs e)
        {
            ShiftTimes shifttime = new ShiftTimes();
            shifttime.Show();
            this.Hide();
        }

        private void buttonShiftSchedule_Click(object sender, EventArgs e)
        {
            ShiftSchedules shiftschedule = new ShiftSchedules();
            shiftschedule.Show();
            this.Hide();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }
    }
}
