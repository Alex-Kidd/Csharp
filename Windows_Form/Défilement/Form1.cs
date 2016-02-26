using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Défilement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //r
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            label1.BackColor = Color.FromArgb(trackBar1.Value,0,0);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
            label1.BackColor = Color.FromArgb(trackBar1.Value, 0, 0);
          

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            label1.BackColor = Color.FromArgb(trackBar1.Value, 0, 0);
        }

        //v

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
            label2.BackColor = Color.FromArgb(0,trackBar2.Value,0);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = (int)numericUpDown2.Value;
            label2.BackColor = Color.FromArgb(0,trackBar2.Value,0);
           
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
            label2.BackColor = Color.FromArgb(0,trackBar2.Value,0);
           
        }

        //b

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            numericUpDown3.Value = trackBar3.Value;
            label3.BackColor = Color.FromArgb(0,0,trackBar3.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = (int)numericUpDown3.Value;
            label3.BackColor = Color.FromArgb(0,0,trackBar3.Value);
            

        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Value = trackBar3.Value;
            label3.BackColor = Color.FromArgb(0,0,trackBar3.Value);
        }



            //mélange

        private void label1_BackColorChanged(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void label2_BackColorChanged(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void label3_BackColorChanged(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
    }
}
