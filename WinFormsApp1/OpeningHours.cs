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
    //this program will maintain and accept the opening hours and details of a specific shop'
    //the data will be loaded onto the OpeningHours.csv file
    public partial class OpeningHours : Form
    {
        string fileLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "Locations.csv";
        StreamReader csvDataLocation = null;//creates a variable to load the data from the csv file
        List<LocationRecord> LocationRecords = new List<LocationRecord>();
        string fileOpeningHour = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "OpeningHours.csv";
        StreamReader csvDataOpeningHour = null;//creates a variable to load the data from the csv file
        List<OpeningHourRecord> OpeningHourRecords = new List<OpeningHourRecord>();
        public OpeningHours()
        {
            InitializeComponent();
        }

        //This will be used to redirect the user to the main menu
        //once clicked, it will exit the policy page and reopen the main menu
        private void buttonMainMenuOH_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void textLoginId_TextChanged(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void textLocationId_TextChanged(object sender, EventArgs e)
        {

        }

        //Once the id of the location is entered, it will check its validation
        //If valid, it will show the location or it will say invalid if invalid id in inputted
        //This will also show the name of the location
     
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
                        // textShopName.Text = LineValues[1].ToString();
                        // textShopAddress.Text = LineValues[2].ToString();
                        // textShopDayStart.Text = LineValues[3].ToString();
                        // textShopDayEnd.Text = LineValues[4].ToString();
                        return;
                    }
                }
                MessageBox.Show("Invalid Location ID");
                textLocationId.Text = "";
                textLocationName.Text = "";
                textLocationId.Focus();
            }
        }
        //this checks for whether the day is valid or already in use
        //if valid, it will show the day
        //if invalid, it will show a message box saying invalid day
        //if already in use, it will show a message box saying already in use
        //this will also check for the location id and day already existing in the file
        //if it does, it will show a message box saying already in use
        //if not, it will show the day
        private void textDay_Validated(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textDay.Text)))
            {
                if (string.IsNullOrWhiteSpace(textLocationId.Text))
                {
                    MessageBox.Show("Please enter a valid Location ID");
                    textLocationId.Focus();
                }
                // checking for valid day
                // if valid, it will show the day
                //  if invalid, it will show a message box saying invalid day
                //ranging from Monday - Sunday
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
                            // if it does, it will show a message box saying already in use
                            // if not, it will show the day
                            if ((textLocationId.Text == LineValues[0].ToString()) && (textDay.Text == LineValues[1].ToString())) 
                            {
                                MessageBox.Show("Location ID and Day already existing in the file");
                                textDay.Text = "";
                                textDay.Focus();
                                csvDataOpeningHour.Close();
                                return;
                            }
                        }
                        csvDataOpeningHour.Close();
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
                    //if invalid, it will show a message box saying invalid day
                    MessageBox.Show("Invalid Day: Must be Monday/Tuesday/Wednesday/Thurday/Friday/Saturday/Sunday");
                    textDay.Text = "";
                    textDay.Focus();
                }
            }
        }

      //the button will first check if the data is inputted incase it is valid or in use
      //if not, it will be loaded into the csv file or it would say in use only or invalid
      //if the data is valid, it will be loaded into the csv file   
      //if the data is in use, it will show a message box saying already in use
      //if the data is invalid, it will show a message box saying invalid
      //if the data is blank, it will show a message box saying blank

        private void buttonSaveOH_Click(object sender, EventArgs e)
        //the error messages if following slots are blank after the user presses save
        {
            // validating all textbox 
            if (string.IsNullOrWhiteSpace(textLocationId.Text))
            {
                MessageBox.Show("Location Id Cannot be blank");
                textLocationId.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textDay.Text))
            {
                MessageBox.Show("Day Cannot be blank");
                textDay.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textStartTime.Text))
            {
                MessageBox.Show("Start Time Cannot be blank");
                textStartTime.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textEndTime.Text))
            {
                MessageBox.Show("End Time Cannot be blank");
                textEndTime.Focus();
                return;
            }
            // writing data to the file
            //this lets the user know that the opening hour that they inputted ha been saved into the file
            //it will let the user know it has been saved
            //it will also clear the textboxes
            //it will also focus on the location id textbox
            //it will also show a message box saying new opening hour record saved
            
            var sb = new StringBuilder();
            var line = "";
            line += textLocationId.Text + ","  + textDay.Text + "," + textStartTime.Text + "," + textEndTime.Text ;
            sb.AppendLine(line);
            TextWriter sw = new StreamWriter(fileOpeningHour, true);
            sw.Write(sb.ToString());
            sw.Close();
            MessageBox.Show("New Opening Hour Record Saved");
            textLocationId.Text = "";   
            textDay.Text = "";
            textStartTime.Text = "";
            textEndTime.Text = "";
            textLocationId.Focus();
        }

    }

   //this defines the location details records structure
    public class LocationRecord
    {
        //This defines the login dettails records structure//
        public string? LocationId { get; set; }
        public string? ShopName { get; set; }
        public string? ShopAddress { get; set; }
        public string? ShopDayStart { get; set; }
        public string? ShopDayEnd { get; set; }
    }
    //this defines the opening hour records structure
    public class OpeningHourRecord
    {
        public string? LocationId { get; set; }
        public string? Day { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
    }
}
