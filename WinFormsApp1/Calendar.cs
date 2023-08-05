using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this is where you will find all of the dates
namespace WinFormsApp1
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }
        //this is the button that will take you back to the main menu
        private void buttonMainMenuE_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
      }
    }
