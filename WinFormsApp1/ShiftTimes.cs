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
        string fileLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "Locations.csv";
        StreamReader csvDataLocation = null;//creates a variable to load the data from the csv file
        List<LocationRecord> LocationRecords = new List<LocationRecord>();
        string fileOpeningHour = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "OpeningHours.csv";
        StreamReader csvDataOpeningHour = null;//creates a variable to load the data from the csv file
        List<OpeningHourRecord> OpeningHourRecords = new List<OpeningHourRecord>();

        public ShiftTimes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMainMenuST_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonSaveSF_Click(object sender, EventArgs e)
        {

        }

        private void textDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLocationId_Validated(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textLocationId.Text)))
            {

                if (File.Exists(fileLocation)) // tests to see if file exists      
                {
                    csvDataLocation = new StreamReader(File.OpenRead(fileLocation));
                }
                else
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

        private void textDay_Validated(object sender, EventArgs e)
        {
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
                                MessageBox.Show("Location ID and Day   existing in the file");
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
}
