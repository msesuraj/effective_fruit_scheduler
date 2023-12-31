﻿using System;
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
    //this will show where all the shifts have been scheduled from the employee section
    //this will show the shifts that have been scheduled for each employee
    public partial class ShiftSchedules : Form
    {
        string fileShiftSchedule = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "ShiftSchedules.csv";
        StreamReader csvDataShiftSchedule = null;//creates a variable to load the data from the csv file

        public ShiftSchedules()
        {
            InitializeComponent();
        }

        private void dateTimePickerHireDate_ValueChanged(object sender, EventArgs e)
        {

        }

        //redirects to the main menu
        //this will take you back to the main menu
        private void buttonMainMenuSS_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        //this will search for the shifts that have been scheduled

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          
            if (File.Exists(fileShiftSchedule)) // this conducts a test to see if the inputed file exists      
            {
                csvDataShiftSchedule = new StreamReader(File.OpenRead(fileShiftSchedule));
            }
            else
            {
                MessageBox.Show(fileShiftSchedule);
                MessageBox.Show("ShiftSchedule.csv Data File not found");
                buttonSearch.Focus();
            }
            //this will show the shifts that have been scheduled
            
            List<string> LineValues = new List<string>();
            var shiftScheduleRecords = new List<ShiftScheduleRecord>();
            string line;
            while ((line = csvDataShiftSchedule.ReadLine()) != null)
            {
                LineValues = line.Split(',').ToList();
                //filter by date
                if (LineValues[0] == dateTimePickerSelectDate.Value.ToString("dd/MM/yyyy"))
                {
             
                    var shiftScheduleRecord = new ShiftScheduleRecord()
                    {
                        ShiftDate = LineValues[0],
                        Location = LineValues[1],
                        ShiftDay = LineValues[2],
                        Shift = LineValues[3],
                        WorkType = LineValues[4],
                        EmployeeName = LineValues[5]
                    };
                    shiftScheduleRecords.Add(shiftScheduleRecord);
                }
            }
            //this will show the shifts that have been scheduled
            dataGridViewSS.DataSource = shiftScheduleRecords;
        }
    }

    //this shows the records of the shifts that have been added
    public class ShiftScheduleRecord
    {
        public string ShiftDate { get; set; }
        public string Location { get; set; }
        public string ShiftDay { get; set; }
        public string Shift { get; set; }
        public string WorkType { get; set; }
        public string EmployeeName { get; set; }
    }

}
