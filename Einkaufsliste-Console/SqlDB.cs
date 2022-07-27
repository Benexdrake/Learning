using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einkaufsliste_Console
{
    public class SqlDB
    {
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        List<Items> items = new List<Items>();

        public void connectSql(string sql)
        {
            try
            {
                //Data Source die IP der SQL, Initial Catalog der Name der Datenbank, Userid der Login Name und Password der Login
                con = new MySqlConnection(@"Data Source = dragooncastle.ddns.net; Initial Catalog = Einkaufsliste; User Id = benexdrake; Password = ");
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void readtSql(string sql)
        {
            // Löscht zu erst die Liste und verbindet sich dann mit der Datenbank
            items.Clear();
            connectSql(sql);
            reader = cmd.ExecuteReader();
            // Wenn Reader Zeilen hat, wird gelesen um dann alle Einträge in einer Liste zu speichern um diese dann abzurufen.
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    items.Add(new Items
                    {
                        Person = reader.GetString(0),
                        ProduktName = reader.GetString(1),
                        Anzahl = reader.GetInt16(2),
                        LadenName = reader.GetString(3)
                    });
                }
            }
            // Ruft die gespeicherte Liste ab
            seeList(items);
        }

        public void writeSql(string sql)
        {
            connectSql(sql);
        }

        public void deleteList(string sql)
        {
            connectSql(sql);
        }

        public void seeList(List<Items> items)
        {

            // Mit der Foreach Schleife, wird die Liste items in item gespeichert und dann abgerufen
            foreach (var item in items)
            {
                Console.WriteLine(item.Person + " braucht " + item.Anzahl + "x " + item.ProduktName + " von " + item.LadenName);
            }

        }
    }
}
