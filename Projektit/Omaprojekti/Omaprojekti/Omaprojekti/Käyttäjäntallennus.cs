using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Omaprojekti

{

    class Käyttäjäntallennus
    {
  
     
   
        string numeroidentulostus = string.Empty;
        YhdistäSQL yhdistäminen = new YhdistäSQL();
        public bool TunnustenTallennus(string klikit)
        {

            MySqlCommand komento = new MySqlCommand();
            string poistokysely = "DELETE FROM pelintallennus where ID > @poist; ";
            komento.Connection = yhdistäminen.otaYhteys();
            komento.CommandText = poistokysely;
 

            komento.Parameters.Add("@poist", MySqlDbType.UInt32).Value = 0;

            yhdistäminen.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhdistäminen.suljeYhteys();

            }
            else
            {
                yhdistäminen.suljeYhteys();

            }

            string lisäyskysely = "INSERT INTO pelintallennus " +
                "(Totalclicks) " +
                "VALUES (@klik); ";
            komento.CommandText = lisäyskysely;
            komento.Connection = yhdistäminen.otaYhteys();



            komento.Parameters.Add("@klik", MySqlDbType.VarChar).Value = klikit;


            yhdistäminen.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhdistäminen.suljeYhteys();
                return true;
            }
            else
            {
                yhdistäminen.suljeYhteys();
                return false;
            }
        }
     
    }
}
