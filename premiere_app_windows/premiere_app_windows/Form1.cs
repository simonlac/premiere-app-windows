using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace premiere_app_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // private void Form_prin_click(object sender, EventArgs e)
        //{
        //Button senderButton = (Button)sender;
        //if (senderButton.Text == "Valider") { senderButton.Text = "bonsoir"; }
        //else senderButton.Text = "Valider";

        //}
        private void Form_prin_click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            if (senderButton.Name == "Form_prin") button1.Text = "button2";
            else if (senderButton.Name == "button1") Form_prin.Text = "bouton 1";
            label1.Text = senderButton.Text + " vient d'être cliqué";
            senderButton.Text = "Bouton cliqué";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
