using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;


namespace GraGUI
{
    public partial class Form1 : Form
    {
       // private Gra g;

        int rand;
        int ruchy;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;

        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            //try-catch
            int a = int.Parse(textBoxZakresOd.Text);
            int b = int.Parse(textBoxZakresDo.Text);

            if (b > a)
            { //swap
                int temp = b;
                b = a;
                a = temp;
            }
            Random generator = new Random();
            rand = generator.Next(b, a + 1);
            //MessageBox.Show(rand.ToString());

           losowanieStart.Visible = true;
           groupBoxLosuj.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = false;
            groupBoxLosuj.Enabled = true;
            losowanieStart.Visible = false;
            buttonNowaGra.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rand.ToString());
            wynik.Visible = true;
            int propozycja = Convert.ToInt32(textBoxPropozycja.Text);
            if (propozycja > rand)
            {
                wynik.ForeColor = Color.Red;
                wynik.Text = "Za dużo";
                ruchy++;
            }
            else
                if (propozycja < rand)
            {
                wynik.ForeColor = Color.Red;
                wynik.Text = "Za mało";
                ruchy++;
            }
            else
            {
                wynik.ForeColor = Color.Green;
                wynik.Text = "Wygrałeś!";
                textBoxPropozycja.Enabled = false;
                buttonSprawdz.Enabled = false;
                buttonPrzerwij.Enabled = false;
                buttonHistoria.Visible = true;
                MessageBox.Show(ruchy.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxZakresOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPropozycja_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int propozycja = Convert.ToInt32(textBoxPropozycja);
        }
    }
}
