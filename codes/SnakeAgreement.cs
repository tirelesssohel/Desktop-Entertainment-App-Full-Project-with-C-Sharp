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
    public partial class SnakeAgreement : Form
    {
        public SnakeAgreement()
        {
            InitializeComponent();
        }

       

      

        private void SnakeAgreement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SnakeGamePage sgp = new SnakeGamePage();
            sgp.Show();
            this.Hide();
        }
    }
}
