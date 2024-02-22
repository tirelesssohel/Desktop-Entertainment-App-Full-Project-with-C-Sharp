using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// project report for non technical person + presentation slide
// click korle photo dakhabe list akare thakbe
// connect to database
// dot axps file run koraite hobe
// difference between dot aspx and dot net
// c# job requirements
// c# vs desktop application
// C# github e push korte hobe

namespace DesktopEntertainmentApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void snakeGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SnakeGamePage sgp = new SnakeGamePage();
            sgp.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PicturePuzzle pp = new PicturePuzzle();
            pp.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarRacing cr = new CarRacing();
            cr.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FlappyBird fb = new FlappyBird();
            fb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SnakeGamePage sgp = new SnakeGamePage();
            sgp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PicturePuzzle pp = new PicturePuzzle();
            pp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarRacing cr = new CarRacing();
            cr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlappyBird fb = new FlappyBird();
            fb.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusicPlayer mp = new MusicPlayer();
            mp.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VideoPlayer vp = new VideoPlayer();
            vp.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhotoEditor pe = new PhotoEditor();
            pe.Show();
            this.Hide();
        }
    }
}
