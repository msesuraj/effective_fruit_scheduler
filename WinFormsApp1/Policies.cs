using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this shows the policies of the company
//it will show the guidelines of the business//this shows the policies of the company

namespace WinFormsApp1
{
    //Each policy will go over the do's and don't that should occur in a business   
        
    public partial class Policies : Form
    {
        public Policies()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //This will be used to redirect the user to the main menu
        //once clicked, it will exit the policy page and reopen the main menu

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            //this will redirect the user to the main menu
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
