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
        private Gra g;

      
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
            if (String.IsNullOrEmpty(textBoxZakresOd.Text) || String.IsNullOrEmpty(textBoxZakresDo.Text))
            {
                MessageBox.Show("Nie podałeś poprawnie zakresu!");
            }
            else
            {
            int a = int.Parse(textBoxZakresOd.Text);
            int b = int.Parse(textBoxZakresDo.Text);
             
                g = new Gra(a, b);

           losowanieStart.Visible = true;
           losowanieStart.Enabled = true;
           groupBoxLosuj.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = false;
            groupBoxLosuj.Enabled = true;
            losowanieStart.Visible = false;
            buttonNowaGra.Enabled = true;
            labelWynik.Visible = false;
            groupBoxStatystyki.Visible = false;
            textBoxZakresDo.Text = null;
            textBoxZakresOd.Text = null;
            textBoxPropozycja.Text = null;
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
            labelWynik.Visible = true;
            
       
           int propozycja = Convert.ToInt32(textBoxPropozycja.Text);
            Gra.Odp odp = g.Ocena(propozycja);
            switch (odp)
            {
                case Gra.Odp.ZaMalo:
                    labelWynik.Text = "Za mało!";
                    labelWynik.ForeColor = Color.Red;
                    break;
                case Gra.Odp.ZaDuzo:
                    labelWynik.Text = "Za dużo!";
                    labelWynik.ForeColor = Color.Red;
                    break;
                case Gra.Odp.Trafiono:
                    labelWynik.Text = "TRAFIONO!";
                    labelWynik.ForeColor = Color.Green;
                    WyswietlStatystyki();
                    break;
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

        private void labelStatystyki_Click(object sender, EventArgs e)
        {

        }
        private void WyswietlStatystyki()
        {
            groupBoxStatystyki.Visible = true;
            labelStatystyki1.Text = $"Liczba ruchów: {g.Historia.Count}";
            labelStatystyki2.Text = $"Czas gry: {g.AktualnyCzas}";
        }
    }
}
