using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Game_Dev_
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameEngine.load();
        }
        int counter = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            counter--;
            if (counter == 0)
                timer1.Stop();
            lblTimer.Text = counter.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; 
            timer1.Start();
            lblTimer.Text = counter.ToString();
            gameEngine.game();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
