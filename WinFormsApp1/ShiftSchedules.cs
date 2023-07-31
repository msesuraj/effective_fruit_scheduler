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

        private void buttonMainMenuSS_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //write code to populate data frame from ShiftSchedules.csv 
            // var lines = File.ReadAllLines(fileShiftSchedule);
            // var list = new List<ShiftScheduleRecord>();
            // foreach (var line in lines)
            // {
            //     var values = line.Split(',');
            //      MessageBox.Show(values[0]);
            //    // if (values.Length==2) // use this to check date
            //     //{
            //         var shiftScheduleRecord = new ShiftScheduleRecord() { ShiftDate = values[0], Location = values[1] };
            //         list.Add(shiftScheduleRecord); 
            //     //}
            // }
            if (File.Exists(fileShiftSchedule)) // tests to see if file exists      
            {
                csvDataShiftSchedule = new StreamReader(File.OpenRead(fileShiftSchedule));
            }
            else
            {
                MessageBox.Show(fileShiftSchedule);
                MessageBox.Show("ShiftSchedule.csv Data File not found");
                buttonSearch.Focus();
            }
            List<string> LineValues = new List<string>();
            var shiftScheduleRecord = new List<ShiftScheduleRecord>();
            string line;
            while ((line = csvDataShiftSchedule.ReadLine()) != null)
            {
                // Console.WriteLine(line);
                LineValues = line.Split(',').ToList();
                MessageBox.Show(LineValues[0]);
            }
            
            //dataGridViewSS.DataSource = list;
        }
    }

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
