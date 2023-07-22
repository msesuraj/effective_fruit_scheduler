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
                    MessageBox.Show("Invalid Day: Must be Monday/Tuesday/Wednesday/Thurday/Friday/Saturday/Sunday");
                    textDay.Text = "";
                    textDay.Focus();
                }
            }
        }

        private void buttonSaveOH_Click(object sender, EventArgs e)
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
            // Now writing ito the OpeningHours.csv file
            // openingHoursRecords.Add(new OpeningHoursRecord
            // {
            //     LocationId = textLocationId.Text,
            //     Day = textDay.Text,
            //     StartTime = textStartTime.Text,
            //     EndTime = textEndTime.Text
            // });
            // foreach (var obj in openingHoursRecords)
            // {
                  var sb = new StringBuilder();
                  //sb = new StringBuilder();
                var line = "";
                //line += prop.GetValue(obj, null) + ",";
                line += textLocationId.Text + ","  + textDay.Text + "," + textStartTime.Text + "," + textEndTime.Text + ",";
            // foreach (var prop in info)
            // {
            //     line += prop.GetValue(textLocationId.Text, null) + ",";
            // }
           // line = line.Substring(0, line.Length - 1);
                sb.AppendLine(line);
                TextWriter sw = new StreamWriter(fileOpeningHour, true);
                sw.Write(sb.ToString());
                sw.Close();
            // }
            MessageBox.Show("New Opening Hour Record Saved");
            textLocationId.Text = "";   
            textDay.Text = "";
            textStartTime.Text = "";
            textEndTime.Text = "";
            textLocationId.Focus();
        }

    }

    public class LocationRecord
    {
        //This defines the login dettails records structure//
        public string? LocationId { get; set; }
        public string? ShopName { get; set; }
        public string? ShopAddress { get; set; }
        public string? ShopDayStart { get; set; }
        public string? ShopDayEnd { get; set; }
    }
    public class OpeningHourRecord
    {
        //This defines the login dettails records structure//
        public string? LocationId { get; set; }
        public string? Day { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
    }
}
