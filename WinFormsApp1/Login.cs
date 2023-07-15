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
 

    public partial class Login : Form
    {
        StreamReader csvData = null;//creates a variable to load the data from the csv file
        List<LoginDetailsRecord> LoginDetailsRecords = new List<LoginDetailsRecord>();
        // string fileLoc = Directory.GetCurrentDirectory() + @"..\..\..\data\OpenHours.csv"; //it will store the file's location
        // string parentOfStartupPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "Orders.xml";
        string fileLoc = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "LoginDetails.csv";


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

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
             if (textLoginId.Text == "" || textPassword.Text == "")
                {
                MessageBox.Show("Please enter a valid Login ID and Password");
                return;
                }

              
             CsvLoad(); // loads file to csv file

             //when the login details are wrong then clear the text
             // 
            //  textBoxLoginId.Text = "";
            //  textBoxPassword.Text = "";

             MainMenu mainMenu = new MainMenu();
             mainMenu.Show();
             this.Hide();
        }

        void CsvLoad()
        {
            // this function loads the csv data into the programming, if file is not found,
            // it will lead to an error (expected file is OpenHours.csv)
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
    }

    public class LoginDetailsRecord
    {
        //This defines the login dettails records structure//
        public string? LoginId{ get; set; } 
        public string? Password{ get; set; }
    }
}
