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
    public partial class FormPong : Form
    {
        bool goUp;                          // dvizenje gore
        bool goDown;                        // dvizenje dole
        int pPaddleSpeed;                   // brzina na panel na igracot
        int cPaddleSpeed;                   // brzina na panel na kompjuterot
        int pScore;                         // score na igrac
        int cScore;                         // score na kompjuter
        Random rand;                        // random pozicija na topka posle postignat gol
        BALLxy ballXY;                      // gi cuva vrednostite na koordinatite na topkata
        struct BALLxy                       //koordinati za kade se naoga topkata
        {
            public int x;     
            public int y;
            
        }
        public FormPong()
        {
            InitializeComponent();
            cPaddleSpeed = 10;               //brzina na panel
            pPaddleSpeed = 5;
            pScore = 0;                     //poceten score 0:0
            cScore = 0;
            ballXY.x = 5;                   //brzina na dvizenje na topka, 5 pixels
            ballXY.y = 5;
            rand = new Random();
        }

        private void FormPong_Load(object sender, EventArgs e)
        {
            this.Text = "Player: " + pScore + " | Computer: " + cScore;        //ke go prikazuva rezultatot 
            picPlayer.Left = 0;
            picPlayer.Top = (ClientSize.Height - picPlayer.Height) / 2;         //visinata na prozorecot - visinata na panelot za da se pozicionira na sredina
            picComputer.Top = (ClientSize.Height - picComputer.Height) / 2;
            picComputer.Left = (ClientSize.Width - picComputer.Width);          //poziciniranje na panelot na kompjuterot 

            picDivider.Top = 0;                                                  //pozicioniranje na linijata na sredina   
            picDivider.Height = ClientSize.Height;
            picDivider.Left = (ClientSize.Width - picDivider.Width) / 2;

            picBall.Left = (ClientSize.Width / 2) + 20;                               //startna pozicija na topkata, nekade na sredina i plus 20 pikseli vo desno za da ne e apla sredina
            picBall.Top = (ClientSize.Height - picBall.Height) / 2;                   //ja pozicionira topkata tocno na sredina (ni pogore ni podole)
            this.FormBorderStyle = FormBorderStyle.FixedSingle;                         //ja onevozmozuva opcijata za resize na prozorecot
            this.MaximizeBox = false;                                                  //ja onevozmozuva opcijata: "otvori na cel ekran"
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = "Player: " + pScore + " | Computer: " + cScore;
            picBall.Top -= ballXY.y;        // topkata ja mrdame za 5 pikseli nagore
            picBall.Left -= ballXY.x;       // i 5 pikseli nalevo
            picComputer.Top += cPaddleSpeed; // palkata na kompjuterot isto taka ja mrdame prvobitno nagore
            
            // so ovoj if proveruvame dali palkata na kompjuterot udrila gore ili dole na prozorecot
            // ako udrila togas samo ja menjame nasokata
            // primer ako se dvizela nagore i udrila gore, sega kje se dvizi nadole se dodeka ne udri dolu i povtorno da se smeni nasokata
            if (picComputer.Top < 0 || picComputer.Top > (ClientSize.Height - picComputer.Height)) 
            {
                cPaddleSpeed *= -1;
                
            }

            // computer dobiva poen, ako topkata dojde do 0 na x oskata odnosno levo kaj igracot
            // vo toj slucaj topkata sega e na polovinata na igracot
            if (picBall.Left < -15)
            {
                cScore += 1;
                picBall.Left = ((ClientSize.Width - picBall.Width) / 2) - 200;
                // random pozicija za od kade pocnuva topkata na polovinata na igracot koga gubi poen
                picBall.Top = rand.Next(ClientSize.Height);
                // ja menuvame nasokata na dvizenje na topkata
                ballXY.x *= -1;
            }

            // player dobiva poen, ako topkata dojde skros desno
            // vo ovoj slucaj topkata kje pocne da se dvizi od polovinata na computer-ot
            // + 15 pikseli za topkata da vleze do polovina
            if(picBall.Left + picBall.Width >= ClientSize.Width + 15)
            {
                pScore += 1;
                // topkata e vo desnata polovina
                picBall.Left = ((ClientSize.Width - picBall.Width) / 2) + 200;
                // random pozicija na y oskata
                picBall.Top = rand.Next(ClientSize.Height);
                // ja menuvame nasokata na dvizenje
                ballXY.x *= -1;
                
            }

            // dali se udrila gore ili dole
            if(picBall.Top < 0 || picBall.Top + picBall.Height > ClientSize.Height)
            {
                // ja menuvame nasokata na y oskata
                // ako odela nagore sega kje odi nadolu
                ballXY.y *= -1;

                SoundPlayer zidsound = new SoundPlayer(@"C:/Users/user/Desktop/PongGame/PongGame/Sounds/zid.wav");
                zidsound.Play();
            }

            // dali udrila vo nekoja od palkite
            if(picBall.Bounds.IntersectsWith(picPlayer.Bounds) || 
                picBall.Bounds.IntersectsWith(picComputer.Bounds))
            {
                // ja menuvame nasokata na x oskata
                ballXY.x *= -1;
                SoundPlayer lenta = new SoundPlayer(@"C:/Users/user/Desktop/PongGame/PongGame/Sounds/lenta.wav");
                lenta.Play();
            }

            // ako ima uste pikseli nagore, pomesti ja palkata na igracot nagore
            if(goUp && picPlayer.Top > 0)
            {
                picPlayer.Top -= pPaddleSpeed;
                
            }

            // ako ima uste pikseli nadolu, pomesti ja palkata na igracot nadolu
            if(goDown && picPlayer.Top < ClientSize.Height - picPlayer.Height)
            {
                picPlayer.Top += pPaddleSpeed;
            }
            
            // koj prv postigne 5 poeni pobeduva
            if(pScore >=5 || cScore >= 5)
            {
                timer.Stop();
                this.Text = "Player: " + pScore + " | Computer: " + cScore;
                MessageBox.Show(string.Format("{0} wins!", pScore >= 5 ? "Player" : "Computer"));
            }
        }

        private void FormPong_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                goUp = true;
                goDown = false;
            }
            if(e.KeyCode == Keys.S)
            {
                goDown = true;
                goUp = false;
            }
        }

        private void pbSPpause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            pbSPpause.Hide();
            pbSPplay.Show();
        }

        private void pbSPplay_Click(object sender, EventArgs e)
        {
            timer.Start();
            pbSPplay.Hide();
            pbSPpause.Show();
        }

        private void pbSPback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
