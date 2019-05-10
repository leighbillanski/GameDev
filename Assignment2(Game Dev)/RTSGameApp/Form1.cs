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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            engine.start();
            //string mp = engine.getMap.getMapArray[2, 3] + "";
            //label1.Text = mp;
           // engine.start();
            //richTextBox1.Text = "";
           for (int i = 0; i < 20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    label1.Text = engine.Map.getMapArray[i,j];
                }
            }
        }
    }
}
    

