using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ListProperty
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        void verifNoms (string textBox1)
        {
            Regex rd = new Regex(@"[a-zA-Z/-]");
            if (rd.IsMatch(textBox1))
            {
                count++;
                this.listBox1.Items.Add(textBox1);
                label8.Text = Convert.ToString(count);
            }
            else
            {
                MessageBox.Show("format_incorrect", "###########################");
            }
        }
        int count = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            verifNoms(textBox1.Text);
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selec = listBox1.SelectedIndex;
            textBox2.Text = Convert.ToString(selec);
            label10.Text = listBox1.SelectedItem.ToString();
            label9.Text = Convert.ToString(selec);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter && textBox1.Text!="")
            {
                verifNoms(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex rd = new Regex(@"[0-9]");
            if (rd.IsMatch(textBox2.Text))
            {
                listBox1.SelectedIndex = Int32.Parse(textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
} 