using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopEntertainmentApp
{
    public partial class CarRacing : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 10;  //
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft = false, goright = false;


        public CarRacing()
        {
            InitializeComponent();
            ResetGame();
        }

        private void keysdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
                goright = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
                goleft = false;
            }
        }

        private void keysup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                goright = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                goleft = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            score++;

            if(goleft == true && player.Left > 10)
            {
                
                player.Left -= playerSpeed;
                goleft = false;
            }

            if(goright == true && player.Left < 210)     // 320
            {
               
                player.Left += playerSpeed;
                goright = false;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 276)        // 424
            {
                roadTrack2.Top = -276;      // -424
            }
            if (roadTrack1.Top > 276)
            {
                roadTrack1.Top = -276;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;


            if (AI1.Top > 430)       // 530
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 430)
            {
                changeAIcars(AI2);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }


            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 3;    // 20
                trafficSpeed = 4;     //22
            }

            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 4;     // 27
                roadSpeed = 5;        // 25
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }


            tempCar.Top = carPosition.Next(10, 400) * -1;    // 100, 400) * -


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 90);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(100, 200);
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;
            btnGoBack.Enabled = true;
        }

        private void ResetGame()
        {
            btnStart.Enabled = false;
            btnGoBack.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 2;    // 12
            trafficSpeed = 3;     // 15

            AI1.Top = carPosition.Next(50, 400) * -1;     // (200, 500) * -1; 
            AI1.Left = carPosition.Next(5, 90);

            AI2.Top = carPosition.Next(50, 400) * -1;      // 200, 500) * -1;
            AI2.Left = carPosition.Next(100, 200);

            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
    }
}
