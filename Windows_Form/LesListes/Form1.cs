using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesListes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count -1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && !comboBox1.Items.Contains(comboBox1.Text) && !listBox1.Items.Contains(comboBox1.Text))
            comboBox1.Items.Add(comboBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string s in comboBox1.Items)
            {
                listBox1.Items.Add(s);
            }
            comboBox1.Text = "";
            comboBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.Items)
            {
                comboBox1.Items.Add(s);
            }           
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;

            }
        }
    }
}
