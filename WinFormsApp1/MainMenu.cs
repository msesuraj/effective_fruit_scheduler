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
    //This code brings you to the main menu to see the other pages.
    //This will be where the user can choose to go to different pages of the software to access them.
    //Each page within the software will have a different usage and purpose in terms of their functionality
    //When the data is inputted, it will go into the csv files which has data for opening hours, employee details, etc
    //if an error occurrs no data will be added to the csv files
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
          //this button will be clicked if the user wants to log out
        //once the message "goodbye" pops up, the software turns off
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }
        //each button will redirect the user to the different pages by the preference of the user
        private void pictureBoxOpeningHours_Click(object sender, EventArgs e)
        {

        }

        //once the button is clicked, it will redirect the user to the policy page
        //there, they can view the guidelines of the business
        private void buttonPolicy_Click(object sender, EventArgs e)
        {
            Policies polices = new Policies();
            polices.Show();
            this.Hide();
        }

        //once the button is clicked, it will redirect the user to the opening hours page
        //there, they can input the business opening hours for each days
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
        //once the button is clicked, it will redirect the user to the employees page
        //there, they add the details of the employees who work at the business
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.Show();
            this.Hide();
        }

        //once the button is clicked, it will redirect the user to the shift times page
        //there, they can add the times for different shifts and the jobs for different employees
        private void buttonShiftTimes_Click(object sender, EventArgs e)
        {
            ShiftTimes shifttime = new ShiftTimes();
            shifttime.Show();
            this.Hide();
        }

        //once the button is clicked, it will redirect the user to the shift scheduling page
        //there, they can schedule different shifts
            private void buttonShiftSchedule_Click(object sender, EventArgs e)
        {
            ShiftSchedules shiftschedule = new ShiftSchedules();
            shiftschedule.Show();
            this.Hide();
        }

        //once the button is clicked, it will redirect the user to the calendar page
        //there, they can see all of the shifts that will occur on certain dates and who is working there
        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }
    }
}
