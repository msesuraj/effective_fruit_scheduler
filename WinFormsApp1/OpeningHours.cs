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
        string fileLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "Location.csv";
        StreamReader csvDataLocation = null;//creates a variable to load the data from the csv file
        List<LocationRecord> LocationRecords = new List<LocationRecord>();
    
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
            //validate_textLocationId_empty();
            if (! (string.IsNullOrWhiteSpace(textLocationId.Text)))
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

        private void buttonSaveOH_Click(object sender, EventArgs e)
        {
            // validating all textbox 
            if (string.IsNullOrWhiteSpace(textLocationId.Text))
            {
                MessageBox.Show("Location Id Cannot be blank");
                textLocationId.Focus();
            }
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
}
