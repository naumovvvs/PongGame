using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace PongGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Pong Game";
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            FormPong single = new FormPong();
            single.Show();
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            TwoPlayer twoPlayer = new TwoPlayer();
            twoPlayer.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
