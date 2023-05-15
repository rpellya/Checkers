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
    public partial class UserNameForm : Form
    {
        public UserNameForm(string styleColor)
        {
            InitializeComponent();
            this.styleColor = styleColor;
        }

        string styleColor;

        private void StartGame_Click(object sender, EventArgs e)
        {
            string player1;
            string player2;

            player1 = textBox1.Text;
            player2 = textBox2.Text;

            RussianCheckersForm russianCheckersForm = new RussianCheckersForm(styleColor, player1, player2);

            Visible = false;

            russianCheckersForm.ShowDialog();

            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
