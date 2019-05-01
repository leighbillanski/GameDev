using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSGameApp
{
    public partial class Form1 : Form
    {
        GameEngine engine = new GameEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKey.Text = "Key:" + Environment.NewLine + Environment.NewLine
                + "M Melee Unit                                                 R Ranged Unit" + Environment.NewLine + Environment.NewLine
                + "Color indicates the different teams";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            timer1.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string title = "Exit";
            MessageBoxButtons boxButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, boxButtons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = System.DateTime.Now.ToLongTimeString();
            
            engine.start();

            //show Grid
            richTextBox1.Text = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    string ob = engine.map.Grid[i, j];
                    if (!ob.Equals(Map.FIELD_SYMBOL))
                    {
                        foreach(Unit u in engine.UnitsOnMap)
                        {
                            richTextBox1.Text = u.Symbol;
                        }
                    }
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
