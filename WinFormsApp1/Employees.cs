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
    //this will bring you to the employee page
    //the slots are used to input the employees' details
    //if slots aren't filled, it would lead to an error message
    //due to at least one of or all slots are blank
    //Once the slots are filled, when the user presses save
    //the data will be loaded onto the csv file
    
    public partial class Employees : Form
    {
        string fileEmployee = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../data/")) + "Employees.csv";
        StreamReader csvDataEmployee = null;//creates a variable to load the data from the csv file
        List<EmployeeRecord> EmployeeRecords = new List<EmployeeRecord>();
        public Employees()
        {
            InitializeComponent();
        }

        private void buttonMainMenuE_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

       //This is where an employee's details are inputted
       //The software will check from the csv file if it already exists
        private void textEmployeeNumber_TextChanged(object sender, EventArgs e)
        {

        }
        //this will check to see if the number is valid or if it exists
        private void textEmployeeNumber_Validated(object sender, EventArgs e)
        {
            //MessageBox.Show("Invalid employee number"); 
            if (!(string.IsNullOrWhiteSpace(textEmployeeNumber.Text)))
            {
                if (File.Exists(fileEmployee)) // tests to see if file exists      
                {
                    
                    csvDataEmployee = new StreamReader(File.OpenRead(fileEmployee));
                    List<string> LineValues = new List<string>();
                    string line;
                    while ((line = csvDataEmployee.ReadLine()) != null)
                    {
                        LineValues = line.Split(',').ToList();
                        // checking Employee Number already exist in the file
                        if (textEmployeeNumber.Text == LineValues[0].ToString())
                        {
                            MessageBox.Show("Employee Number already existing in the file");
                            textEmployeeNumber.Text = "";
                            textEmployeeNumber.Focus();
                            csvDataEmployee.Close();
                            return;
                        }

                    }
                    csvDataEmployee.Close();
                }
                else
                {
                    MessageBox.Show(fileEmployee);
                    MessageBox.Show("Employews.csv Data File not found");
                    textEmployeeNumber.Focus();
                }
            }
        }

        //This will ask for employee details to be inputted

        public class EmployeeRecord
        {
            //This defines the login dettails records structure//
            public string? EmployeeNumber { get; set; }
            public string? EmployeeName { get; set; }
            public string? EmployeePhoneNumber { get; set; }
            public string? EmployeeAddress { get; set; }
            public string? EmployeeHireDate { get; set; }
            public string? EmployeeTerminatinoDate { get; set; }
            public string? EmployeeTaxFileNumber { get; set; }
        }

        //This will save the employee details onto the csv file
        //If the slots are blank, it will show an error message
        //If the slots are filled, it will save the data onto the csv file
        //It will also show a message box to show that the data has been saved
        //It will also clear the slots once the data has been saved    
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // validating all textbox 
            if (string.IsNullOrWhiteSpace(textEmployeeNumber.Text))

            {
                MessageBox.Show("Employee Number Cannot be blank");
                textEmployeeNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textEmployeeName.Text))
            {
                MessageBox.Show("Employee Name Cannot be blank");
                textEmployeeName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textPhoneNumber.Text))
            {
                MessageBox.Show("Employee Phone Number Cannot be blank");
                textPhoneNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textAddress.Text))
            {
                MessageBox.Show("Employee Address Cannot be blank");
                textAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textTaxFileNumber.Text))
            {
                MessageBox.Show("Employee Tax File Number Cannot be blank");
                textTaxFileNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(dateTimePickerHireDate.Text))
            {
                MessageBox.Show("Employee Hire Date Cannot be blank");
                dateTimePickerHireDate.Focus();
                return;
            }
            var sb = new StringBuilder();
            var line = "";
            //MessageBox.Show(dateTimePickerTerminationDate.Value.ToString("dd/MM/yyyy"));
            line += textEmployeeNumber.Text + "," + textEmployeeName.Text + "," + textPhoneNumber.Text + "," + textAddress.Text + "," + dateTimePickerHireDate.Value.ToString("dd/MM/yyyy") + ",";
            //when the termination date is default then save the termination date as blank
            if (dateTimePickerTerminationDate.Value.ToString("dd/MM/yyyy") == "30/12/9998")
                line += "" + ",";
            else
                line += dateTimePickerTerminationDate.Value.ToString("dd/MM/yyyy") + ",";
            line += textTaxFileNumber.Text;
            sb.AppendLine(line);
            TextWriter sw = new StreamWriter(fileEmployee, true);
            sw.Write(sb.ToString());
            sw.Close();
            MessageBox.Show("New Employee Record Saved");
            // clearing all textbox
            textEmployeeNumber.Text = "";
            textEmployeeName.Text = "";
            textPhoneNumber.Text = "";
            textAddress.Text = "";
            textTaxFileNumber.Text = "";
            dateTimePickerHireDate.Text = "";
            dateTimePickerTerminationDate.CustomFormat = " "; ;
            textEmployeeNumber.Focus();
        }
        //this is an optional slot to fill if employees have a date to be terminated
        //if the slot is blank, it will show the termination date as default
        //if the slot is filled, it will show the termination date as the date inputted 
        //by the user
        private void dateTimePickerTerminationDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTerminationDate.CustomFormat = "dd/MM/yyyy";
        }
    }
}
