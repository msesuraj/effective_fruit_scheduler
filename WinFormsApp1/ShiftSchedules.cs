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
            var lines = File.ReadAllLines("contacts.csv");
            var list = new List<Contact>();
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length==2)
                {
                    var contact = new Contact() { Name = values[0], Phone = values[1] };
                    list.Add(contact); 
                }
            }
            //list.ForEach(x => Console.WriteLine($"{x.Name}\t{x.Phone}"));
            dataGridViewSS.DataSource = list;
        }
    }

   public class ShiftScheduleRecord
    {
        public string location { get; set; }
        public string Day { get; set; }
        public string Shift { get; set; }
        public string work { get; set; }
        public string date { get; set; }
        public string ShiftType { get; set; }
        public string ShiftStatus { get; set; }
    }
  
}
