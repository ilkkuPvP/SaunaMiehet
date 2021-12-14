using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace Omaprojekti
{
    public partial class Peli : Form
    {
        public string taulukonarvo;

        string numeroidentulostus = string.Empty;

        Käyttäjäntallennus tallennus = new Käyttäjäntallennus();
        YhdistäSQL yhdistäminen = new YhdistäSQL();
        double autoAikaNyt = 0;

        public int kissaOstoKerta = 0;
        public int autoOstoKerta = 0;


        public int totalClicks = 0;
        public int clicks = 0;
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
            ClicksLB.Text = "Clicks (c): " + clicks + "c";
            TotalClicksLB.Text = "Total Clicks: " + totalClicks;
        }

        private void TakaisinPeliBT_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Haluatko varmasti poistua?\nTämä nollaa nykyisen tallennuksesi.", "Poistuminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                KirjauduForm f1 = new KirjauduForm();
                f1.Show();
            }
            else
            {

            }
            
        }

        private void Peli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KauppaBT_Click(object sender, EventArgs e)
        {
            KauppaPanel.Visible = true;

            KerroinOsto2BT.Text = "+2x (" + clickKerroin2Hinta + "k)";
            KerroinOstoBT.Text = "+1x (" + clickKerroinHinta + "c)";

            if(autoOstoKerta >= 5)
            {
                AutoClickerOstoBT.Text = "Ostettu";
            }
            else
            {
                AutoClickerOstoBT.Text = autoClickerNopeus + "s (" + autoClickerHinta + "c)";
            }
            if (kissaOstoKerta >= 1)
            {
                KissaOstoBT.Text = "Ostettu";
            }
            else
            {
                KissaOstoBT.Text = "Kissat (" + kissaHinta + "c)";
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
            clicks += 1 * clickKerroin;
            clicks += 1 * clickKerroin2;
            totalClicks += 1 * clickKerroin;
            totalClicks += 1 * clickKerroin2;

            ClicksLB.Text = "Clicks (c): " + clicks + "c";
            TotalClicksLB.Text = "Total Clicks: " + totalClicks;

            if (KissaClicksLB.Visible == true)
            {
                kissat += 1;
                KissaClicksLB.Text = "Kissat (k): " + kissat + "k";
            }
        }

        // KERROIN //
        private void KerroinOstoBT_Click(object sender, EventArgs e)
        {
           KerroinOstoBT.Text = "+1x (" + clickKerroinHinta + "c)"; 

            if (clickKerroinMaara == 0 && clicks >= clickKerroinHinta)
            {

                clicks -= clickKerroinHinta;
                ClicksLB.Text = "Clicks (c): " + clicks + "c";

                clickKerroin += 1;
                clickKerroinHinta *= 2;
                KerroinOstoBT.Text = "+1x (" + clickKerroinHinta + "c)";
            }
        }

        // AUTO CLICKER //
        private void AutoClickerOstoBT_Click(object sender, EventArgs e)
        {
            
            if (autoOstoKerta == 0 && clicks >= autoClickerHinta)
            {
                clicks -= autoClickerHinta;
                ClicksLB.Text = "Clicks (c): " + clicks + "c";

                autoClickerNopeus = 5;
                autoAikaNyt = autoClickerNopeus * 1000;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                AutoClickerT.Enabled = true;
                AutoClickerLaskinT.Enabled = true;
                AutoClickerOstoBT.Text = autoClickerNopeus + "s (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
                AutoClickerLaskinLB.Text = "Automaatti: " + autoClickerNopeus;
                AutoClickerLaskinLB.Visible = true;
            }

            if (autoOstoKerta == 1 && clicks >= autoClickerHinta)
            {
                clicks -= autoClickerHinta;
                ClicksLB.Text = "Clicks (c): " + clicks + "c";

                autoClickerNopeus = 4;
                autoAikaNyt = autoClickerNopeus * 1000;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                //AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = autoClickerNopeus + "s (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
                AutoClickerLaskinLB.Text = "Automaatti: " + autoClickerNopeus;
            }

            if (autoOstoKerta == 2 && clicks >= autoClickerHinta)
            {
                clicks -= autoClickerHinta;
                ClicksLB.Text = "Clicks (c): " + clicks + "c";

                autoClickerNopeus = 3;
                autoAikaNyt = autoClickerNopeus * 1000;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                //AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = autoClickerNopeus + "s (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
                AutoClickerLaskinLB.Text = "Automaatti: " + autoClickerNopeus;
            }

            if (autoOstoKerta == 3 && clicks >= autoClickerHinta)
            {
                clicks -= autoClickerHinta;
                ClicksLB.Text = "Clicks (c): " + clicks + "c";

                autoClickerNopeus = 2;
                autoAikaNyt = autoClickerNopeus * 1000;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                //AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = autoClickerNopeus + "s (" + autoClickerHinta + "c)";
                autoOstoKerta += 1;
                AutoClickerLaskinLB.Text = "Automaatti: " + autoClickerNopeus;
            }

            if (autoOstoKerta == 4 && clicks >= autoClickerHinta)
            {
                clicks -= autoClickerHinta;
                ClicksLB.Text = "Clicks (c): " + clicks + "c";

                autoClickerNopeus = 1;
                autoAikaNyt = autoClickerNopeus * 1000;
                autoClickerHinta *= 2;
                AutoClickerT.Interval = autoClickerNopeus * 1000;
                //AutoClickerT.Enabled = true;
                AutoClickerOstoBT.Text = autoClickerNopeus + "s (Ostettu)";
                autoOstoKerta += 1;
                AutoClickerLaskinLB.Text = "Automaatti: " + autoClickerNopeus;
            }

        }

        // AUTO CLICKER AJASTIN //
        private void AutoClickerT_Tick(object sender, EventArgs e)
        {
            /*
            clicks += 1 * clickKerroin;
            clicks += 1 * clickKerroin2;
            totalClicks += 1 * clickKerroin;
            totalClicks += 1 * clickKerroin2;
            ClicksLB.Text = "Clicks (c): " + clicks+ "c";
            TotalClicksLB.Text = "Total Clicks: " + totalClicks;
            */

            ClickBT_Click(sender, e);
        }

        // AUTO CLICKER TULKKI //
        private void AutoClickerLaskinT_Tick(object sender, EventArgs e)
        {
            autoAikaNyt -= 500;

            if (autoAikaNyt == 0)
            {
                autoAikaNyt = autoClickerNopeus * 1000;
            }
            AutoClickerLaskinLB.Text = "Automaatti: " + (autoAikaNyt / 1000).ToString();
        }

        // LATAA KÄYTTÄJÄN PELIN TALLENNUKSEN //
        private void LataaTiedotBT_Click(object sender, EventArgs e)
        {
            taulukonarvo = "";
              totalClicks = 0;

        numeroidentulostus = string.Empty;
        TunnustenLataaminen();

            void TunnustenLataaminen()
            {

                MySqlCommand cmd = new MySqlCommand("select Totalclicks from pelintallennus ", yhdistäminen.otaYhteys());






                yhdistäminen.avaaYhteys();

                using (var reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        taulukonarvo = reader.GetString(reader.GetOrdinal("Totalclicks"));
                  




                        string a = taulukonarvo;



                        for (int i = 0; i < a.Length; i++)
                        {
                            if (Char.IsDigit(a[i]))
                                numeroidentulostus += a[i];
                        }

                        yhdistäminen.suljeYhteys();
                        int uus = int.Parse(numeroidentulostus);
                        var hakeminen = new Peli();
                        totalClicks += uus;
                        MessageBox.Show("Tiedot ladattu onnistuneesti", "Tietojen lataaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TotalClicksLB.Text = "Total Clicks: " + totalClicks;
                    }
                    else
                    {
                        MessageBox.Show("Tietoja ei ole olemassa", "Tietojen lataaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        // TALLENTAA NYKYISEN PELIN TILAN KÄYTTÄJÄLLE //
        private void TallennaTiedotBT_Click(object sender, EventArgs e)
        {
            string totalclicks = TotalClicksLB.Text.ToString();
            tallennus.TunnustenTallennus(totalclicks);
            MessageBox.Show("Tiedot tallennettu onnistuneesti", "Tietojen tallentaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // KISSOJEN OSTO //
        private void KissaOstoBT_Click(object sender, EventArgs e)
        {
          
            if (clicks >= kissaHinta && kissaOstoKerta == 0)
            {
                clicks -= kissaHinta;
                ClicksLB.Text = "Clicks (c): " + clicks + "c";
                KissaClicksLB.Text = "Kissat (k): " + kissat + "k";
                KissaOstoBT.Text = "Ostettu";
                KissaClicksLB.Visible = true;
                kissaOstoKerta += 1;
            }
        }

        // TOINEN KERROIN //
        private void KerroinOsto2BT_Click(object sender, EventArgs e)
        {
          KerroinOsto2BT.Text = "+1x (" + clickKerroin2Hinta + "k)";

            if (clickKerroin2Maara == 0 && kissat >= clickKerroin2Hinta)
            {
                kissat -= clickKerroin2Hinta;
                KissaClicksLB.Text = "Kissat (k): " + kissat + "k";

                clickKerroin2 += 2;
                clickKerroin2Hinta *= 3;
                KerroinOsto2BT.Text = "+2x (" + clickKerroin2Hinta + "k)";
            }
        }

        private void TallennusPB_Click(object sender, EventArgs e)
        {
            if(TallennaPanel.Visible == false)
            {
                TallennaPanel.Visible = true;
            }
            else
            {
                TallennaPanel.Visible = false;
            }
        }

        private void TallennusPB_MouseEnter(object sender, EventArgs e)
        {
            TallennusPB.Location = new Point(720, 370);
            TallennusPB.Size = new System.Drawing.Size(72, 72);
        }

        private void TallennusPB_MouseLeave(object sender, EventArgs e)
        {
            TallennusPB.Location = new Point(724, 374);
            TallennusPB.Size = new System.Drawing.Size(64, 64);
        }


    }
}
