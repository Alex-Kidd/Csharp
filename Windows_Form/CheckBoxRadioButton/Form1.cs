using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = checkBox1.Checked;
            if (checkBox1.Checked == false)
            {
                Rouge.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = checkBox2.Checked;
            if (checkBox2.Checked == false)
            {
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)            
        {
            groupBox4.Visible = checkBox3.Checked;
            if (checkBox3.Checked == false)
            {
                radioButton7.Checked = false;
                radioButton8.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (Rouge.Checked == true)
            {
                panel1.BackColor = Color.Red;
            }
            else
            {
                panel1.BackColor = SystemColors.Window;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel1.BackColor = Color.LightGreen;
            }
            else
            {
                panel1.BackColor = SystemColors.Window;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel1.BackColor = Color.Blue;
            }
            else
            {
                panel1.BackColor = SystemColors.Window;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                panel1.ForeColor = Color.Red;
            }

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                panel1.ForeColor = Color.Black;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                panel1.ForeColor = Color.White;
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label2.Text = textBox1.Text.ToUpper();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                label2.Text = textBox1.Text.ToLower();
            }
        }
    }
}
