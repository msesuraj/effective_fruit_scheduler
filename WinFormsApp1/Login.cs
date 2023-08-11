using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{

    //This is where a user can input a user ID and password to access the software
    //.e.g. ID: a, Password: a
    //the user ID and password will be stored in a csv file which is located in the data folder
    //currently, there's no form to create a user
    //the csv file can be best edited in Excel

    public partial class Login : Form
    {
        StreamReader csvData = null;//creates a variable to load the data from the csv file
        List<LoginDetailsRecord> LoginDetailsRecords = new List<LoginDetailsRecord>();
        // string fileLoc = Directory.GetCurrentDirectory() + @"..\..\..\data\OpenHours.csv"; //it will store the file's location
        // string parentOfStartupPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "Orders.xml";
        string fileLoc = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "LoginDetails.csv";

        //This login method, pops up once the application is opened
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       //This will ask the user to enter an ID and password that would be considered valid
        //the CheckingValidLogin function is used to check if the login and password that has been inputted is valid
        //Once the password and login is enterred, it will get confirmation with the csv file before opening to the main menu
        //or say that the password and login that has been inputted is invalid

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textLoginId.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Please enter a valid Login ID and Password");
                return;
            }


            CsvLoad(); // loads file to csv file
            if (CheckingValidLogin()) // validating login and password
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
        }

        void CsvLoad()
        {
            // this function loads the csv data into the programming, if file is not found,
            // it will lead to an error (expected file is OpenHours.csv)
            //if file aready exists, it would say that the file is already in existence
            if (File.Exists(fileLoc)) // tests to see if file exists      
            {
                csvData = new StreamReader(File.OpenRead(fileLoc));
            }
            else
            {
                
                MessageBox.Show(fileLoc);
                MessageBox.Show("Login Username/Password Data File not found");
                return;
            }
        }

       //This function will check the csv file for the validaty of the login and password
        //if not valid, it would say error and ask to enter ID and password again
        //if valid, it will be written as true for the boolean value
        //if the login and password is valid, it will open the main menu
        //if not, it will say that the login and password is invalid
        //if the login and password is invalid, it will ask to enter the login and password again
        private bool CheckingValidLogin()
        {
            List<string> LineValues = new List<string>();
            string line;
            while ((line = csvData.ReadLine()) != null)
            {
                Console.WriteLine(line);
                LineValues = line.Split(',').ToList();

                // openHoursRecords.Add(new OpenHoursRecord { LocationId = LineValues[0].ToString(),
                //                                         Day = LineValues[1].ToString(),
                //                                         StartTime = LineValues[2].ToString(),
                //                                         EndTime =  LineValues[3].ToString() 
                //                                         });

                //displaying the message box with values from list
                // MessageBox.Show(LineValues[0].ToString() + " " + LineValues[1].ToString());
                // checking if the login details are correct
                if (textLoginId.Text == LineValues[0].ToString() && textPassword.Text == LineValues[1].ToString())
                {
                   // MessageBox.Show("Login Successful");
                    return true;
                }
            }
            // if login details are incorrect
            MessageBox.Show("Invalid Login Username and Password");
            textLoginId.Text = "";
            textPassword.Text = "";
            return false;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //This defines the login details records structure//
    public class LoginDetailsRecord
    {
        //This defines the login dettails records structure//
        public string? LoginId { get; set; }
        public string? Password { get; set; }
    }
}
