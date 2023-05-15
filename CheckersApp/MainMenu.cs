using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public string styleColor = "black";

        private void SettingsForm_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);

            Visible = false;

            settings.ShowDialog();

            Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            UserNameForm userNameForm = new UserNameForm(styleColor);

            Visible = false;

            userNameForm.ShowDialog();

            Visible = true;
        }
    }
}
