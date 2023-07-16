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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void pictureBoxOpeningHours_Click(object sender, EventArgs e)
        {

        }

        private void buttonPolicy_Click(object sender, EventArgs e)
        {
            Policies polices = new Policies();
            polices.Show();
            this.Hide();
        }
    }
}
