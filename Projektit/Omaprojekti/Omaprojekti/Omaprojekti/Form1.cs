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
        Kirjautuminen kirjautuminen = new Kirjautuminen();
        Käyttäjäntarkistus Teko = new Käyttäjäntarkistus();
        Tunnuksenpoisto Poistaminen = new Tunnuksenpoisto();
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
            if (SalasanaRegPanelTB.Text != "" || KäyttäjäRegPanelTB.Text != "")
            {
                kirjautuminen.kirjautumistiedot(KäyttäjäRegPanelTB.Text, SalasanaRegPanelTB.Text);
                MessageBox.Show("Rekisteröityminen onnistui.", "Rekisteröityminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KäyttäjäTB.Text = "";
                SalasanaTB.Text = "";
                RegPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Rekisteröityminen epäonnistui: Käyttäjätunnus tai salasana puuttuu.", "Rekisteröityminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            if (Teko.käyttis(KäyttäjäTB.Text, SalasanaTB.Text) == true)
            {
                MessageBox.Show("Kirjautuminen onnistui", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kirjautuminen epäonnistui: Käyttäjätunnus tai salasana virheellinen.", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PoistaTunnuksiaPanelBT_Click(object sender, EventArgs e)
        {
            PoistaTuPanel.Visible = true;
        }

        private void TakaisinPoistaTuPanelBT_Click(object sender, EventArgs e)
        {
            PoistaTuPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PoistaTunnusBT_Click(object sender, EventArgs e)
        {
            käyttäjä = KäyttäjäPoistaTuPanelLB.Text;
            salasana = SalasanaPoistaTuPanelLB.Text;

            if (Poistaminen.Poisto(käyttäjä, salasana) == true)
            {

                MessageBox.Show("Poistaminen onnistui", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Poistaminen epäonnistui", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
         

        }
    }
}
