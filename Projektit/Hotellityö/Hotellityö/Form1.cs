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


        public Form1()
        {

            
                InitializeComponent();

            
        }

        toinen opiskelija = new toinen();
        private void button4_Click(object sender, EventArgs e)
        {
            string enimi = Sukunimi.Text;
            string snimi = Etunimi.Text;
            string puh = Puhelinnumero.Text;
            string maa = Maa.Text;

            if (enimi == "" || snimi == "" || puh == "" || maa == "")
            {
                MessageBox.Show("Mainitsethan asiakkaan etunimen, sukunimen, puhelinnumeron ja maan.", "Asiakkaan lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*Boolean lisaaAsiakas = */ opiskelija.lisaaOpiskelija(enimi, snimi, puh, maa);
                /*
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei voida lisätä", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
                TietoTauluDG.DataSource = opiskelija.HaeOpiskelija();

                ID.Text = "";
                Sukunimi.Text = "";
                Etunimi.Text = "";
                Puhelinnumero.Text = "";
                Maa.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Sukunimi.Text = "";
            Etunimi.Text = "";
            Puhelinnumero.Text = "";
            Maa.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(ID.Text == "")
            {
                MessageBox.Show("ID-kohtaan poistettavan asiakkaan ID", "Asiakkaan poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tunnus = ID.Text;
            if (opiskelija.poistaOpiskelija(tunnus))
            {
                TietoTauluDG.DataSource = opiskelija.HaeOpiskelija();

                ID.Text = "";
                Sukunimi.Text = "";
                Etunimi.Text = "";
                Puhelinnumero.Text = "";
                Maa.Text = "";
            }
            Tyhjennä.PerformClick();
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TietoTauluDG.DataSource = opiskelija.HaeOpiskelija();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietoTauluDG.DataSource = opiskelija.HaeOpiskelija();
        }

        private void TietoTauluDG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (TietoTauluDG.Rows[e.RowIndex].Cells[0].Value == null)
            {
                ID.Text = "";
                Sukunimi.Text = "";
                Etunimi.Text = "";
                Puhelinnumero.Text = "";
                Maa.Text = "";
            }
            else
            {

                ID.Text = TietoTauluDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                Etunimi.Text = TietoTauluDG.Rows[e.RowIndex].Cells[1].Value.ToString();
                Sukunimi.Text = TietoTauluDG.Rows[e.RowIndex].Cells[2].Value.ToString();
                Puhelinnumero.Text = TietoTauluDG.Rows[e.RowIndex].Cells[3].Value.ToString();
                Maa.Text = TietoTauluDG.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
