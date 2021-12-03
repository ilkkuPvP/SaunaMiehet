using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omaprojekti
{
    public partial class KirjauduForm : Form
    {
        public KirjauduForm()
        {
            InitializeComponent();
        }

        //Hakee juttuja :D
        Kirjautuminen kirjautuminen = new Kirjautuminen();
        Käyttäjäntarkistus Teko = new Käyttäjäntarkistus();
        Tunnuksenpoisto Poistaminen = new Tunnuksenpoisto();

        //Käyttäjien poistoa varten lyhennykset
        string käyttäjä;
        string salasana;

        private void RekisteröityminenBT_Click(object sender, EventArgs e)
        {
            RegPanel.Visible = true;
        }

        private void TakaisinRegPanelBT_Click(object sender, EventArgs e)
        {
            RegPanel.Visible = false;
        }

        private void RegPanelBT_Click(object sender, EventArgs e)
        {
            if (KäyttäjäRegPanelTB.Text != "" || SalasanaRegPanelTB.Text != "")
            {
                kirjautuminen.kirjautumistiedot(KäyttäjäRegPanelTB.Text, SalasanaRegPanelTB.Text);
                MessageBox.Show("Rekisteröityminen onnistui.", "Rekisteröityminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KäyttäjäTB.Text = "";
                SalasanaTB.Text = "";
                RegPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Rekisteröityminen epäonnistui:\nKäyttäjätunnus tai salasana puuttuu.", "Rekisteröityminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            if (Teko.käyttis(KäyttäjäTB.Text, SalasanaTB.Text))
            {
                MessageBox.Show("Kirjautuminen onnistui", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kirjautuminen epäonnistui:\nKäyttäjätunnus tai salasana virheellinen.", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PoistaTunnuksiaPanelBT_Click(object sender, EventArgs e)
        {
            PoistaTuPanel.Visible = true;
        }

        private void TakaisinPoistaTuPanelBT_Click(object sender, EventArgs e)
        {
            PoistaTuPanel.Visible = false;
            KäyttäjäPoistaTuPanelLB.Text = "";
            SalasanaPoistaTuPanelLB.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PoistaTunnusBT_Click(object sender, EventArgs e)
        {
            käyttäjä = KäyttäjäPoistaTuPanelLB.Text;
            salasana = SalasanaPoistaTuPanelLB.Text;

            if (Poistaminen.Poisto(käyttäjä, salasana))
            {
                MessageBox.Show("Poistaminen onnistui", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Poistaminen epäonnistui:\nKäyttäjätunnus tai salasana virheellinen.", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            KäyttäjäPoistaTuPanelLB.Text = "";
            SalasanaPoistaTuPanelLB.Text = "";



        }

        private void SalasanaNaytaBT_Click(object sender, EventArgs e)
        {
            if(SalasanaNaytaBT.Text == "Näytä")
            {
                SalasanaTB.PasswordChar = '\0';
                SalasanaRegPanelTB.PasswordChar = '\0';
                SalasanaPoistaTuPanelLB.PasswordChar = '\0';
                SalasanaNaytaBT.Text = "Piilota";
            }
            else if(SalasanaNaytaBT.Text == "Piilota")
            {
                SalasanaTB.PasswordChar = '*';
                SalasanaRegPanelTB.PasswordChar = '*';
                SalasanaPoistaTuPanelLB.PasswordChar = '*';
                SalasanaNaytaBT.Text = "Näytä";
            }

        }
    }
}
