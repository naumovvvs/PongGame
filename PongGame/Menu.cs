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
        // kolekcija od site formi
        FormCollection fc;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Pong Game";
        }

        // funkcijata vrakja true ako se igra, false ako seuste nema startuvano igra
        // celta e da ne moze da ima dve instaci od igrata istovremeno
        // ili da ima single player i 2 player istovremeno
        private bool alreadyPlaying()
        {

            // site otvoreni formi
            fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                // iteriraj niz otvorenite formi i proveri dali se igra 2 player ili single player
                // ako se igra ne startuvaj
                if (frm.Name == "TwoPlayer" || frm.Name == "FormPong")
                {
                    return true;
                }
            }

            return false;
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            // ako ne se igra, startuvaj single player
            if (!alreadyPlaying())
            {
                FormPong single = new FormPong();
                single.Show();
            }
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            // ako ne se igra, startuvaj two player
            if (!alreadyPlaying())
            {
                TwoPlayer twoPlayer = new TwoPlayer();
                twoPlayer.Show();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
