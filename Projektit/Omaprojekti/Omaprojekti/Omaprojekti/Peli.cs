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
        public int kissaOstoKerta = 0;
        public int autoOstoKerta = 0;

        public int totalClicks = 0;
        public int kissat = 0;

        // TÄÄ RESETTAA ALUSSA JOTEN TARVII NAPIN JOKA LATAA VANHAN TALLENNUKSEN //
        public int clickKerroin = 1; // RESETTII
        public int clickKerroinHinta = 5; // joku 25-50 hyvä alkuhinta
        public int clickKerroinMaara = 0; // RESETTII TAAS

        public int autoClickerNopeus = 5; // RESETTI
        public int autoClickerHinta = 10; //

        public int kissaHinta = 1000; // hinta kannattaa pitää suunnilleen 1000

        public int clickKerroin2 = 0;
        public int clickKerroin2Hinta = 10;
        public int clickKerroin2Maara = 0;

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

            KerroinOsto2BT.Text = "MUL4x (" + clickKerroin2Hinta + "k)";
            KerroinOstoBT.Text = "MUL2x (" + clickKerroinHinta + "c)";

            if(autoOstoKerta >= 5)
            {
                AutoClickerOstoBT.Text = "Ostettu";
            }
            else
            {
                AutoClickerOstoBT.Text = "sek (" + autoClickerHinta + "c)";
            }
            if (kissaOstoKerta >= 1)
            {
                KissaOstoBT.Text = "Ostettu";
            }
            else
            {
                KissaOstoBT.Text = "Kissa (" + kissaHinta + "c)";
            }
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
            totalClicks += 1 * clickKerroin2;
            TotalClicksLB.Text = "Total Clicks: " + totalClicks;

            if (KissaClicksLB.Visible == true)
            {
                kissat += 1;
                KissaClicksLB.Text = "Kissat: " + kissat;
            }
        }

        // KERROIN //
        private void KerroinOstoBT_Click(object sender, EventArgs e)
        {
           KerroinOstoBT.Text = "MUL2x (" + clickKerroinHinta + "c)"; 

            if (clickKerroinMaara == 0 && totalClicks >= clickKerroinHinta)
            {

                totalClicks -= clickKerroinHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                clickKerroin += 1;
                clickKerroinHinta *= 2;
                KerroinOstoBT.Text = "MUL2x (" + clickKerroinHinta + "c)";
            }
        }

        // AUTO CLICKER //
        private void AutoClickerOstoBT_Click(object sender, EventArgs e)
        {
            
            if (autoOstoKerta == 0 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 5;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = "sek (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
            }

            if (autoOstoKerta == 1 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 4;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = "sek (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
            }

            if (autoOstoKerta == 2 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 3;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = "sek (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
            }

            if (autoOstoKerta == 3 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 2;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = "sek (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
            }

            if (autoOstoKerta == 4 && totalClicks >= autoClickerHinta)
            {
                totalClicks -= autoClickerHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                autoClickerNopeus = 1;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = "Ostettu";
                autoOstoKerta += 1;
            }

        }

        // AUTO CLICKER AJASTIN //
        private void AutoClickerT_Tick(object sender, EventArgs e)
        {
            totalClicks += 1 * clickKerroin;
            totalClicks += 1 * clickKerroin2;
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
          
            if (totalClicks >= kissaHinta && kissaOstoKerta == 0)
            {
                totalClicks -= kissaHinta;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;
                KissaClicksLB.Text = "Kissat: " + kissat;
                KissaOstoBT.Text = "Ostettu";
                KissaClicksLB.Visible = true;
                kissaOstoKerta += 1;
            }
        }

        // TOINEN KERROIN //
        private void KerroinOsto2BT_Click(object sender, EventArgs e)
        {
          KerroinOsto2BT.Text = "MUL4x (" + clickKerroin2Hinta + "k)";

            if (clickKerroin2Maara == 0 && kissat >= clickKerroin2Hinta)
            {
                kissat -= clickKerroin2Hinta;
                KissaClicksLB.Text = "Kissat: " + kissat;
                TotalClicksLB.Text = "Total Clicks: " + totalClicks;

                clickKerroin2 += 2;
                clickKerroin2Hinta *= 3;
                KerroinOsto2BT.Text = "MUL4x (" + clickKerroin2Hinta + "k)";
            }
        }
    }
}
