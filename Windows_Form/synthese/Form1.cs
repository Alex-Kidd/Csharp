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

namespace synthese
{


    public partial class Form1 : Form
    {
        static int nbRemboursementAn;
        static double tauxAnnuel;
        static double tauxMensuel;
        static int periodRemb;
        static int nbRemboursement;
        double montantRemboursement;
        int montant;
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbRemboursement = 0;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    periodRemb = 1;
                    nbRemboursementAn = 12;
                    break;
                case 1:
                    periodRemb = 2;
                    nbRemboursementAn = 6;
                    break;
                case 2:
                    periodRemb = 3;
                    nbRemboursementAn = 4;
                    break;
                case 3:
                    periodRemb = 6;
                    nbRemboursementAn = 2;
                    break;
                case 4:
                    periodRemb = 12;
                    nbRemboursementAn = 1;
                    break;
            }
            
            nbRemboursement = trackBar1.Value / periodRemb;
            label5.Text = Convert.ToString(nbRemboursement);
            label9.Text = Convert.ToString (periodRemb)+" remboursement(s) par an";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            nbRemboursement = 0;
            nbRemboursement = trackBar1.Value / periodRemb;
            label5.Text = Convert.ToString(nbRemboursement);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tauxAnnuel = 0.07;
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tauxAnnuel = 0.08;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tauxAnnuel = 0.09;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex name = new Regex("^([ \u00c0-\u01ffa-zA-Z'])+$");
            if (!name.IsMatch(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = SystemColors.Window;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex amount = new Regex(@"^\d+$");
            if (!amount.IsMatch(textBox2.Text))
            {
                textBox2.BackColor = Color.Red;
            }
            else
            {
                textBox2.BackColor = SystemColors.Window;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Red || textBox2.BackColor == Color.Red)
            {
                MessageBox.Show("saisie invalide");
            }
            else
            {
                tauxMensuel = tauxAnnuel / nbRemboursementAn;
                montant = Convert.ToInt32(textBox2.Text);
                montantRemboursement = montant * (tauxMensuel/(1- Math.Pow(1+tauxMensuel,-nbRemboursement)));
                label8.Text = string.Format("{0:0.00}€", montantRemboursement);

            }
        }        
    }
}
