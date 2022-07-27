using System.Data;
using System.Data.SqlClient;


namespace MS_SQL
{
    internal class MSSQLDB
    {
        private static string conString = @$"Data Source=LAPTOP-FK4L396P;Initial Catalog=Sample;Integrated Security=True";
        public MSSQLDB()
        {

        }
        public List<Person> LoadPersonDB()
        {
            List<Person> list = new List<Person>();
            using(SqlConnection con = new SqlConnection(conString))
            {
                string a = "SELECT* FROM[Sample].[dbo].[People];";
                string b = $"  Insert into Sample.dbo.People values ('Test1', 'Test1', 'Test1', 'Test1'); ";
                con.Open();
                SqlCommand cmd = new SqlCommand(a, con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    list.Add(new Person()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        EmailAddress = reader.GetString(3),
                        PhoneNumber = reader.GetString(4)
                    }) ;
                }
                con.Close();
            }
            return list;
        }


        public void WritePersonDB(string sql)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                con.Close();
            }
            
        }
    }
}
