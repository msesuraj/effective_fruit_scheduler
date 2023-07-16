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

    }

    public class LocationRecord
    {
        //This defines the login dettails records structure//
        public string? PhysicalId { get; set; }
        public string? ShopName { get; set; }
        public string? ShopAddress { get; set; }
        public string? ShopDayStart { get; set; }
        public string? ShopDayEnd { get; set; }
    }
}
