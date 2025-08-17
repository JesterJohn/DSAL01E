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
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
        // Codes for disabling the textboxes 
        private void Activity2_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false; 
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;



         //Codes for inserting name of the image inside of the label tool 
            name1lbl.Text = "ADOBO";
            name2lbl.Text = "MENUDO";
            name3lbl.Text = "SHANGHAI";
            name4lbl.Text = "LECHON";
            name5lbl.Text = "SINIGANG";
            name6lbl.Text = "MECHADO";
            name7lbl.Text = "POCHERO";
            name8lbl.Text = "SOPAS";
            name9lbl.Text = "GINILING";
            name10lbl.Text = "MONGGO";
            name11lbl.Text = "PORK SISIG";
            name12lbl.Text = "BICOL EXPRESS";
            name13lbl.Text = "KARE - KARE";
            name14lbl.Text = "PANCIT BIHON";
            name15lbl.Text = "BEEF NILAGA";
            name16lbl.Text = "PORK SIOMAI";
            name17lbl.Text = "BARBEQUE";
            name18lbl.Text = "KALDERETA";
            name19lbl.Text = "TINOLA";
            name20lbl.Text = "PINAKBET";


        }
    }
}
