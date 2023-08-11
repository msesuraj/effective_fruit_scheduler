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
    
    public partial class ShiftTimes : Form
    {
         //this is where data from the following csv files will be used for the code to work'
        //if files aren't in directory, code will not be able to work
        //csv files are able to accessed via an Excel spreadsheet
        //this can allow the user to view the shifts that have been scheduled
        //it required a specific date to be selected for shift that has been scheduled to be viewed
   
        string fileLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "Locations.csv";
        StreamReader csvDataLocation = null;//creates a variable to load the data from the csv file
        List<LocationRecord> LocationRecords = new List<LocationRecord>();
        string fileOpeningHour = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "OpeningHours.csv";
        StreamReader csvDataOpeningHour = null;//creates a variable to load the data from the csv file
        List<OpeningHourRecord> OpeningHourRecords = new List<OpeningHourRecord>();
        string fileShiftTime = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "ShiftTimes.csv";
        StreamReader csvDataShiftTime = null;//creates a variable to load the data from the csv file
        List<ShiftTimeRecord> ShiftTimeRecords = new List<ShiftTimeRecord>();

        //this code asks for the shift times
        //for different shifts that have been scheduled and
        //the employees and their jobs during said scheduled shifts
        //this code also allows the user to add shifts
        public ShiftTimes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //users can use this to redirect to the main menu
        private void buttonMainMenuST_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        //this is where the user can add shifts
        private void buttonSaveSF_Click(object sender, EventArgs e)
        {
            //checks if the slots are filled and valid
            //if not, the user will be prompted to fill in the slots
            //if the slots are filled, the user will be able to add shifts
            //if the slots are not filled, the user will be prompted to fill in the slots
            
            if ((string.IsNullOrWhiteSpace(textLocationId.Text)))
            {
                MessageBox.Show("Please enter a valid Location ID");
                textLocationId.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(textDay.Text)))
            {
                MessageBox.Show("Please enter a valid Day");
                textDay.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(comboBoxShift.Text)))
            {
                MessageBox.Show("Please Select Shift");
                comboBoxShift.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(comboBoxWorkType.Text)))
            {
                MessageBox.Show("Please Select WorkType");
                comboBoxWorkType.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(textBoxNoOfEmployeesRequired.Text)))
            {
                MessageBox.Show("Please enter a valid No Of Employees Required");
                textBoxNoOfEmployeesRequired.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(textBoxShiftStartTime.Text)))
            {
                MessageBox.Show("Please enter a Shift Strt Time");
                textBoxShiftStartTime.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(textBoxShiftEndTime.Text)))
            {
                MessageBox.Show("Please enter a Shift End Time");
                textBoxShiftEndTime.Focus();
            }
            else
            {
                // check to make sure shift already existing in the file
                // if it does, then display error message and return
                // if it does not, then add the shift to the file
                // and display message that shift has been added
                // and clear the form for next shift to be added
                // and set focus to Location ID
                // and return
                if (File.Exists(fileShiftTime)) // tests to see if file exists      
                {
                    csvDataShiftTime = new StreamReader(File.OpenRead(fileShiftTime));
                    List<string> LineValues = new List<string>();
                    string line;
                    while ((line = csvDataShiftTime.ReadLine()) != null)
                    {

                        LineValues = line.Split(',').ToList();

                        // checking if the shift already exist in the file
                        if ((textLocationId.Text == LineValues[0].ToString()) &&
                          (textDay.Text == LineValues[1].ToString()) &&
                          (comboBoxShift.SelectedItem.ToString() == LineValues[2].ToString()) &&
                          (comboBoxWorkType.SelectedItem.ToString() == LineValues[3].ToString()))
                        {
                            MessageBox.Show("Shift already exist in the file");
                            comboBoxShift.Focus();
                            csvDataShiftTime.Close();
                            return;
                        }
                    }
                }
                else
                //error message
                {
                    MessageBox.Show(fileOpeningHour);
                    MessageBox.Show("ShiftTime.csv Data File not found");
                    textLocationId.Focus();
                }

                // write to the CSV file
                // and display message that shift has been added
                // and clear the form for next shift to be added
                // and set focus to Location ID
                // and return
                csvDataShiftTime.Close();
                var sb = new StringBuilder();
                var line1 = "";
                line1 += textLocationId.Text + "," + textDay.Text + "," +
                        comboBoxShift.SelectedItem.ToString() + "," +
                        comboBoxWorkType.SelectedItem.ToString() + "," +
                        textBoxShiftStartTime.Text + "," + textBoxShiftEndTime.Text + "," +
                        textBoxNoOfEmployeesRequired.Text;
                sb.AppendLine(line1);
                TextWriter sw = new StreamWriter(fileShiftTime, true);
                sw.Write(sb.ToString());
                sw.Close();
                MessageBox.Show("New Shift Record Saved");
                textLocationId.Text = "";
                textDay.Text = "";
                comboBoxWorkType.Text = "";
                comboBoxShift.Text = "";
                textBoxShiftStartTime.Text = "";
                textBoxShiftEndTime.Text = "";
                textBoxNoOfEmployeesRequired.Text = "";
                textLocationId.Focus();

            }
        }

        private void textDay_TextChanged(object sender, EventArgs e)
        {

        }

        // Checking if the Location ID is valid
        // if it is, then display the Location Name
        // if it is not, then display error message
        // and set focus to Location ID
        private void textLocationId_Validated(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textLocationId.Text)))
            {

                if (File.Exists(fileLocation)) // tests to see if file exists      
                {
                    csvDataLocation = new StreamReader(File.OpenRead(fileLocation));
                }
                else
                //error message
                {
                    MessageBox.Show(fileLocation);
                    MessageBox.Show("Location.csv Data File not found");
                    textLocationId.Focus();
                }

                List<string> LineValues = new List<string>();
                string line;
                while ((line = csvDataLocation.ReadLine()) != null)
                {
                    // Console.WriteLine(line);
                    LineValues = line.Split(',').ToList();
                    if (textLocationId.Text == LineValues[0].ToString())
                    {
                        textLocationName.Text = LineValues[1].ToString();
                        return;
                    }
                }
                MessageBox.Show("Invalid Location ID");
                textLocationId.Text = "";
                textLocationName.Text = "";
                textLocationId.Focus();
            }
        }

        // Checking if the Day is valid
        // if it is, then display the Day
        //  if it is not, then display error message
        // and set focus to Day
    
        private void textDay_Validated(object sender, EventArgs e)
        {
            //asks for location ID
            if (!(string.IsNullOrWhiteSpace(textDay.Text)))
            {
                if (string.IsNullOrWhiteSpace(textLocationId.Text))
                {
                    MessageBox.Show("Please enter a valid Location ID");
                    textLocationId.Focus();
                }
                if (textDay.Text == "Monday" || textDay.Text == "Tuesday" || textDay.Text == "Wednesday" || textDay.Text == "Thursday" || textDay.Text == "Friday" || textDay.Text == "Saturday" || textDay.Text == "Sunday")
                {
                    // check to make sure location id and Day already existing in the file
                    // if it does, then display error message and return
                    // if it does not, then add the location id and Day to the file
                    // and display message that location id and Day has been added
                    // and clear the form for next location id and Day to be added
                    if (File.Exists(fileOpeningHour)) // tests to see if file exists      
                    {
                        csvDataOpeningHour = new StreamReader(File.OpenRead(fileOpeningHour));
                        List<string> LineValues = new List<string>();
                        string line;
                        while ((line = csvDataOpeningHour.ReadLine()) != null)
                        {
                            LineValues = line.Split(',').ToList();
                            // checking location id and day already exist in the file
                            if ((textLocationId.Text == LineValues[0].ToString()) && (textDay.Text == LineValues[1].ToString()))
                            {
                                textDayStartTime.Text = LineValues[2].ToString();
                                textDayEndTime.Text = LineValues[3].ToString();
                                //textDay.Focus();
                                csvDataOpeningHour.Close();
                                return;
                            }
                        }
                        MessageBox.Show("Location ID and Day for the Opening HOurs Not in OpeningHoours.csv file");
                        csvDataOpeningHour.Close();
                        textDay.Text = "";
                        textDay.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(fileOpeningHour);
                        MessageBox.Show("OpeningHour.csv Data File not found");
                        textDay.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Day: Must be Monday/Tuesday/Wednesday/Thurday/Friday/Saturday/Sunday");
                    textDay.Text = "";
                    textDay.Focus();
                }
            }
        }

    }

    //This defines the  details records structure for shift times//
    public class ShiftTimeRecord
    {
        public string? LocationId { get; set; }
        public string? Day { get; set; }
        public string? Shift { get; set; }
        public string? ShiftStartTime { get; set; }
        public string? ShiftEndTime { get; set; }
        public string? NoOfEmployees { get; set; }
    }
}
