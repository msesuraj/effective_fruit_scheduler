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
                MessageBox.Show("Location Id Not blank");
               // textLocationId.Focus();
        
               
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
