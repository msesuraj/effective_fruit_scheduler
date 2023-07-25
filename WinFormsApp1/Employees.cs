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

        private void textEmployeeNumber_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
             MessageBox.Show(dateTimePickerHireDate.Value.ToString("dd/MM/yyyy"));
             //MessageBox.Show(dateTimePickerHireDate.Value);
        }

        private void dateTimePickerTerminationDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTerminationDate.CustomFormat = "dd/MM/yyyy";
        }
    }
}
