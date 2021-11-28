using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellityö
{

    public partial class Huoneet : Form
    {
        public Huoneet()
        {
            InitializeComponent();
        }

        string Onko;
        string huone;

        toinen Uus = new toinen();
        private void button3_Click(object sender, EventArgs e)
        {
            Uus.poistaHuone(Num.Text);
            Taulu.DataSource = Uus.HaeOpiskelijahuoneista();
        }

        private void Uusi_Click(object sender, EventArgs e)
        {
            Uus.Huone(Num.Text, huone, Puhelin.Text, Onko);
           Taulu.DataSource = Uus.HaeOpiskelijahuoneista();
        }

        private void Huoneet_Load(object sender, EventArgs e)
        {

        }

        private void Kyllä_CheckedChanged(object sender, EventArgs e)
        {
            Onko = "Kyllä";
        }

        private void Ei_CheckedChanged(object sender, EventArgs e)
        {
            Onko = "Ei";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            huone = "Yksiö";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            huone = "Pari";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            huone = "Perhe";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Päivitä_Click(object sender, EventArgs e)
        {
            Taulu.DataSource = Uus.HaeOpiskelijahuoneista();
        }
    }
}
