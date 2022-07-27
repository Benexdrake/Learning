using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Request_Manager.Classes
{
    public class SqlDB
    {
        public bool isLoginOk;
        public List<Classes.Request> requestList = new List<Classes.Request>();
        MySqlConnection con;
        MySqlDataReader reader, LikedReader;
        MySqlCommand cmd;
        bool like;

        bool sqlConnection(string sql)
        {
            try
            {
                string connection = (@"Data Source = localhost; Port = 3306 ; Initial Catalog = mrmdb; User Id = "+Save.UserName+"; Password = "+Save.Password+";");

                con = new MySqlConnection(connection);

                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;
            }
        }

        public void sqlLogin(string sql)
        {
            isLoginOk = sqlConnection(sql);

            if(isLoginOk)
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Save.UserID = reader.GetInt32(0);
                    }
                }
            }
            con.Close();
        }

        public void sqlRead(string sql, bool isLiked)
        {
            isLoginOk = sqlConnection(sql);
            requestList.Clear();

            if (isLoginOk)
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        like = IsLiked(reader.GetInt32(0));
                        
                        requestList.Add(new Classes.Request
                        {
                            requestId = reader.GetInt16(0),
                            requestUserId = reader.GetInt16(1),
                            note = reader.GetString(2),
                            text = reader.GetString(3),
                            category = reader.GetInt16(4),
                            fileName = reader.GetString(5),
                            whiteBox = reader.GetBoolean(6),
                            lowPoly = reader.GetBoolean(7),
                            highPoly = reader.GetBoolean(8),
                            texture = reader.GetBoolean(9),
                            requestDate = reader.GetString(10),
                            available = reader.GetBoolean(11),
                            guid = reader.GetString(13),
                            username = reader.GetString(14),
                            like = this.like
                        }) ;
                    }
                }
            }
            else
            {

            }
            con.Close();
        }

        public void sqlWrite(string sql)
        {
            // Alle Create, Insert, Update, Delete werden hier benutzt
            try
            {
                sqlConnection(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            con.Close();
        }

        private bool IsLiked(int check)
        {
            sqlConnection($"select * from saverequests where SaveUserId = {Classes.Save.UserID} and SRReqID = {check};");
            LikedReader = cmd.ExecuteReader();
                if (LikedReader.HasRows)
                {
                    return true;
                }
                else
                {
                return false;
                }
        }

    }
}
