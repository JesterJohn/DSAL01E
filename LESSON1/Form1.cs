using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Adobo";
            priceTxtbox.Text = "120";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Menudo";
            priceTxtbox.Text = "150";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Shanghai";
            priceTxtbox.Text = "80";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Lechon Baboy";
            priceTxtbox.Text = "150";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Sinigang";
            priceTxtbox.Text = "100";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Pork Sisig";
            priceTxtbox.Text = "85";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Bicol Express";
            priceTxtbox.Text = "90";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Kare-Kare";
            priceTxtbox.Text = "110";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Pancit Bihon";
            priceTxtbox.Text = "70";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Beef Nilaga";
            priceTxtbox.Text = "120";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Pork Siomai";
            priceTxtbox.Text = "65";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Barbeque";
            priceTxtbox.Text = "50";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Kaldereta";
            priceTxtbox.Text = "120";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Tinola";
            priceTxtbox.Text = "100";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Pinakbet";
            priceTxtbox.Text = "110";
        }

        private void itemnameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Clear();
            priceTxtbox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
