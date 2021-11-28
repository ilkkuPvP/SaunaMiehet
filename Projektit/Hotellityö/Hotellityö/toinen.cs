using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotellityö
{
    class toinen
    {

        Class1 yhteys = new Class1();

        public bool lisaaOpiskelija(string enimi, string snimi, string puh, string maa)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisäyskysely = "INSERT INTO hotelliyhteystiedot " +
                "(Etunimi, Sukunimi, Puhelin, Maa) " +
                "VALUES (@enm, @snm, @p, @maa); ";
            komento.CommandText = lisäyskysely;
            komento.Connection = yhteys.otaYhteys();


            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@p", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@maa", MySqlDbType.VarChar).Value = maa;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public bool Huone(string Huone, string Tyyppi, string Puhelin, string Vapaa)
        {

               MySqlCommand komento = new MySqlCommand();
        string lisäyskysely = "INSERT INTO Huoneet" +
            "(Huoneennumero, Tyyppi, Puhelin, Vapaa) " +
            "VALUES (@num, @tyy, @puh, @vao); ";
        komento.CommandText = lisäyskysely;
            komento.Connection = yhteys.otaYhteys();


            komento.Parameters.Add("@num", MySqlDbType.VarChar).Value = Huone;
            komento.Parameters.Add("@tyy", MySqlDbType.VarChar).Value = Tyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = Puhelin;
            komento.Parameters.Add("@vao", MySqlDbType.VarChar).Value = Vapaa;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        




        public DataTable HaeOpiskelija()
        {

            MySqlCommand komento = new MySqlCommand("SELECT * FROM hotelliyhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public DataTable HaeOpiskelijahuoneista()
        {

            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }



        public bool poistaOpiskelija(string ktunnus)
        {

            MySqlCommand komento = new MySqlCommand();
            string poistokysely = "DELETE FROM hotelliyhteystiedot WHERE ID = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }


            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool poistaHuone(string huone)
        {
            MySqlCommand komento = new MySqlCommand();
            string poistokysely = "DELETE FROM huoneet WHERE huoneennumero = @huon";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@huon", MySqlDbType.UInt32).Value = huone;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }


            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }




    }
}
