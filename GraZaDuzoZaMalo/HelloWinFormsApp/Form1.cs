using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelKomunikat1.Text = "Hej, " + textBoxImie.Text + " " + textBoxNazwisko.Text;

            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if (wiek > 0 && wiek < 67)
            {
                labelKomunikat2.Text=string.Format("do emerytury zostalo ci {0} lat", 67 - wiek);
            }
            else if (wiek < 0)
            {
                labelKomunikat2.Text = "Podano błędne dane!";

            }
            else
            {
                labelKomunikat2.Text = "Emeryt :)";
            }

        }
         
    }
}
