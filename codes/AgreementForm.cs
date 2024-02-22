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
    public partial class AgreementForm : Form
    {
        public AgreementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlappyBird fb = new FlappyBird();
            fb.Show();
            this.Hide();
        }
    }
}
