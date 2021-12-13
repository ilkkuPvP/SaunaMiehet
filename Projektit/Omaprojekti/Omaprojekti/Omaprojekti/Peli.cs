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
    public partial class Peli : Form
    {
        public int totalClicks = 0;
        public int Kissat = 0;

        // TÄÄ RESETTAA ALUSSA JOTEN TARVII NAPIN JOKA LATAA VANHAN TALLENNUKSEN //
        public int clickKerroin = 1; // RESETTII
        public int clickKerroinHinta = 5; // joku 25-50 hyvä alkuhinta
        public int clickKerroinMaara = 0; // RESETTII TAAS

        public int autoClickerNopeus = 5; // RESETTI
        public int autoClickerHinta = 10; //

        public int KissaHinta = 10; // hinta kannattaa pitää suunnilleen 1000


        //--------------------------------------------------//
        public Peli()
        {
            InitializeComponent();
        }

        private void Peli_Load(object sender, EventArgs e)
        {
            TotalClicksLB.Text = "Total Clicks: " + totalClicks;
        }

        private void TakaisinPeliBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            KirjauduForm f1 = new KirjauduForm();
            f1.Show();
            
        }

        private void Peli_FormClosed(object sender, FormClosedEventArgs e)
        {
            KirjauduForm f1 = (KirjauduForm)Application.OpenForms["KirjauduForm"];
            f1.Close();
        }

        private void KauppaBT_Click(object sender, EventArgs e)
        {
            KauppaPanel.Visible = true;
        }

        private void TakaisinKauppaBT_Click(object sender, EventArgs e)
        {
            KauppaPanel.Visible = false;
        }
        //--------------------------------------------------//

        // *CLICK* //
        private void ClickBT_Click(object sender, EventArgs e)
        {
            totalClicks += 1 * clickKerroin;
            TotalClicksLB.Text = "Total Clicks: " + totalClicks;

            if (KissaClicksLB.Visible == true)
            {
                Kissat += 1;
                KissaClicksLB.Text = "Kissat: " + Kissat;
            }
        }

        // KERROIN //
        private void KerroinOstoBT_Click(object sender, EventArgs e)
        {
            if(clickKerroinMaara == 0 && totalClicks >= clickKerroinHinta)
            {

                totalClicks -= clickKerroinHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                clickKerroin += 1;
                clickKerroinHinta *= 2;
            }
        }

        // AUTO CLICKER //
        private void AutoClickerOstoBT_Click(object sender, EventArgs e)
        {
            int ostoKerta = 0;
            

            if (ostoKerta == 0 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 5;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;

                ostoKerta += 1;
            }

            if (ostoKerta == 1 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 4;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;

                ostoKerta += 1;
            }

            if (ostoKerta == 2 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 3;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;

                ostoKerta += 1;
            }

            if (ostoKerta == 3 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 2;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;

                ostoKerta += 1;
            }

            if (ostoKerta == 4 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 1;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;

                ostoKerta += 1;
            }

        }

        // AUTO CLICKER AJASTIN //
        private void AutoClickerT_Tick(object sender, EventArgs e)
        {
            totalClicks += 1 * clickKerroin;
            TotalClicksLB.Text = "Total Clicks: " + totalClicks;
        }

        // LATAA KÄYTTÄJÄN PELIN TALLENNUKSEN //
        private void LataaTiedotBT_Click(object sender, EventArgs e)
        {

        }

        // TALLENTAA NYKYISEN PELIN TILAN KÄYTTÄJÄLLE //
        private void TallennaTiedotBT_Click(object sender, EventArgs e)
        {
            
        }

        // KISSA KERROIN //
        private void KissaOstoBT_Click(object sender, EventArgs e)
        {
            int KissaOstoKerta = 0;

            if (totalClicks >= KissaHinta && KissaOstoKerta == 0)
            {
                KissaOstoBT.Text = "Ostettu";
                KissaClicksLB.Visible = true;
                KissaOstoKerta += 1;
            }
        }
    }
}
