using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellityö
{

    public partial class Form1 : Form
    {
        private MainMenu mainMenu;


        public Form1()
        {

            
                InitializeComponent();

            
        }

        toinen opiskelija = new toinen();
        private void button4_Click(object sender, EventArgs e)
        {
            string enimi = Etunimi.Text;
            string snimi = Sukunimi.Text;
            string puh = Puhelinnumero.Text;
            string maa = Maa.Text;



            Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puh, maa);
            if (lisaaAsiakas)
            {
                Console.WriteLine("uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys");
            }
            else
            {
                Console.WriteLine("Ei voida lisätä");
            }
            TietoTauluDG.DataSource = opiskelija.HaeOpiskelija();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Etunimi.Text = "";
            Sukunimi.Text = "";
            Puhelinnumero.Text = "";
            Maa.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {

            string tunnus = ID.Text;
            if (opiskelija.poistaOpiskelija(tunnus))
            {
                TietoTauluDG.DataSource = opiskelija.HaeOpiskelija();
            }
            Tyhjennä.PerformClick();
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TietoTauluDG.DataSource = opiskelija.HaeOpiskelija();
        }

   
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sukunimi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
