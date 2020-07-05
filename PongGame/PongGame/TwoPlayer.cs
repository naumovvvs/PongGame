using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PongGame
{
    public partial class TwoPlayer : Form
    {
        bool goUp1;                          // dvizenje gore igrac 1
        bool goDown1;                        // dvizenje dole igrac 1
        bool goUp2;                          // dvizenje gore igrac 2
        bool goDown2;                        // dvizenje dole igrac 2
        bool stopped;                        // dali timerot e sopren
        int p1PaddleSpeed;                   // brzina na panel na igrac 1
        int p2PaddleSpeed;                   // brzina na panel na igrac 2
        int p1Score;                         // score na igrac 1
        int p2Score;                         // score na igrac 2
        Random rand;                        // random pozicija na topka posle postignat gol
        BALLxy ballXY;                      // gi cuva vrednostite na koordinatite na topkata
        struct BALLxy                       //koordinati za kade se naoga topkata
        {
            public int x;
            public int y;

        }
        public TwoPlayer()
        {
            InitializeComponent();
            p1PaddleSpeed = 5;               //brzina na panel
            p2PaddleSpeed = 5;
            p1Score = 0;                     //poceten score 0:0
            p2Score = 0;
            ballXY.x = 5;                   //brzina na dvizenje na topka, 5 pixels
            ballXY.y = 5;
            rand = new Random();
            stopped = false;
        }

        private void TwoPlayer_Load(object sender, EventArgs e)
        {
            this.Text = "Player 1: " + p1Score + " | Player 2: " + p2Score;        //ke go prikazuva rezultatot 
            picPlayer1.Left = 0;
            picPlayer1.Top = (ClientSize.Height - picPlayer1.Height) / 2;         //visinata na prozorecot - visinata na panelot za da se pozicionira na sredina
            picPlayer2.Top = (ClientSize.Height - picPlayer2.Height) / 2;
            picPlayer2.Left = (ClientSize.Width - picPlayer2.Width);          //poziciniranje na panelot na igrac 2 

            picDivider.Top = 0;                                                  //pozicioniranje na linijata na sredina   
            picDivider.Height = ClientSize.Height;
            picDivider.Left = (ClientSize.Width - picDivider.Width) / 2;

            picBall.Left = (ClientSize.Width / 2) + 20;                               //startna pozicija na topkata, nekade na sredina i plus 20 pikseli vo desno za da ne e apla sredina
            picBall.Top = (ClientSize.Height - picBall.Height) / 2;                   //ja pozicionira topkata tocno na sredina (ni pogore ni podole)
            this.FormBorderStyle = FormBorderStyle.FixedSingle;                         //ja onevozmozuva opcijata za resize na prozorecot
            this.MaximizeBox = false;                                                  //ja onevozmozuva opcijata: "otvori na cel ekran"
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Player 1: " + p1Score + " | Player 2: " + p2Score;
            picBall.Top -= ballXY.y;        // topkata ja mrdame za 5 pikseli nagore
            picBall.Left -= ballXY.x;       // i 5 pikseli nalevo

            // igrac 2 dobiva poen, ako topkata dojde do 0 na x oskata odnosno levo kaj igrac 1
            // vo toj slucaj topkata sega e na polovinata na igrac 1
            if (picBall.Left < -15)
            {
                p2Score += 1;
                picBall.Left = ((ClientSize.Width - picBall.Width) / 2) - 200;
                // random pozicija za od kade pocnuva topkata na polovinata na igrac 1 koga gubi poen
                picBall.Top = rand.Next(ClientSize.Height);
                // ja menuvame nasokata na dvizenje na topkata
                ballXY.x *= -1;
            }

            // player 1 dobiva poen, ako topkata dojde skros desno
            // vo ovoj slucaj topkata kje pocne da se dvizi od polovinata na igrac 2
            // + 15 pikseli za topkata da vleze do polovina
            if (picBall.Left + picBall.Width >= ClientSize.Width + 15)
            {
                p1Score += 1;
                // topkata e vo desnata polovina
                picBall.Left = ((ClientSize.Width - picBall.Width) / 2) + 200;
                // random pozicija na y oskata
                picBall.Top = rand.Next(ClientSize.Height);
                // ja menuvame nasokata na dvizenje
                ballXY.x *= -1;
            }

            // dali se udrila gore ili dole
            if (picBall.Top < 0 || picBall.Top + picBall.Height > ClientSize.Height)
            {
                // ja menuvame nasokata na y oskata
                // ako odela nagore sega kje odi nadolu
                ballXY.y *= -1;
                SoundPlayer zidsound = new SoundPlayer(@"C:/Users/user/Desktop/PongGame/PongGame/Sounds/zid.wav");
                zidsound.Play();
            }

            // dali udrila vo nekoja od palkite
            if (picBall.Bounds.IntersectsWith(picPlayer1.Bounds) ||
                picBall.Bounds.IntersectsWith(picPlayer2.Bounds))
            {
                // ja menuvame nasokata na x oskata
                ballXY.x *= -1;
                SoundPlayer lenta = new SoundPlayer(@"C:/Users/user/Desktop/PongGame/PongGame/Sounds/lenta.wav");
                lenta.Play();
            }

            // ako ima uste pikseli nagore, pomesti ja palkata na igrac 1 nagore
            if (goUp1 && picPlayer1.Top > 0)
            {
                picPlayer1.Top -= p1PaddleSpeed;
            }

            // ako ima uste pikseli nadolu, pomesti ja palkata na igrac 1 nadolu
            if (goDown1 && picPlayer1.Top < ClientSize.Height - picPlayer1.Height)
            {
                picPlayer1.Top += p1PaddleSpeed;
            }

            // ako ima uste pikseli nagore, pomesti ja palkata na igrac 2 nagore
            if (goUp2 && picPlayer2.Top > 0)
            {
                picPlayer2.Top -= p2PaddleSpeed;
            }

            // ako ima uste pikseli nadolu, pomesti ja palkata na igrac 2 nadolu
            if (goDown2 && (picPlayer2.Top < ClientSize.Height - picPlayer2.Height))
            {
                picPlayer2.Top += p2PaddleSpeed;
            }

            // koj prv postigne 5 poeni pobeduva
            if (p1Score >= 5 || p2Score >= 5)
            {
                timer1.Stop();
                this.Text = "Player 1: " + p1Score + " | Player 2: " + p2Score;
                MessageBox.Show(string.Format("{0} wins!", p1Score >= 5 ? "Player 1" : "Player 2"));
            }
        }

        private void TwoPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUp1 = true;
                goDown1 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown1 = true;
                goUp1 = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp2 = true;
                goDown2 = false;
            }
            if(e.KeyCode == Keys.Down)
            {
                goDown2 = true;
                goUp2 = false;
            }
        }

        private void pbTPpause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pbTPpause.Hide();
            pbTPplay.Show();
        }

        private void pbTPplay_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pbTPplay.Hide();
            pbTPpause.Show();
        }

        private void pbTPback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
