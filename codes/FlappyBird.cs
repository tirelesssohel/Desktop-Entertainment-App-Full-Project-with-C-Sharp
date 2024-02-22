using DesktopEntertainmentApp;
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
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;

        public FlappyBird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBrd.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score.ToString();


            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 600;
                score++;
            }
            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 800;
                score++;
            }

            if (flappyBrd.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBrd.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBrd.Bounds.IntersectsWith(ground.Bounds) || flappyBrd.Top < -25
                )
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            MessageBox.Show("Your " + scoreText.Text);
            // scoreText.Text += " ";

            AgreementForm af = new AgreementForm();
            af.Show();
            this.Hide();
        }

        
    }
}
