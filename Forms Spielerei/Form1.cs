using MySql.Data.MySqlClient;
using System.Data;

namespace Forms_Spielerei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            List<Zutaten> z = ReadZutaten("Select * from Getraenk;");
            for (int i = 0; i < z.Count; i++)
            {
                dataGridView1.Rows.Add(z[i].Name, z[i].Alk);
                dataGridView1.Rows[i].Cells[2].Value = (dataGridView1.Rows[i].Cells[2] as DataGridViewComboBoxCell).Items[0];
            }
        }

        private MySqlConnection con;
        private MySqlDataReader reader;
        private MySqlCommand cmd;


        bool sqlConnection(string _sql)
        {
            try
            {
                string connection = (@$"Data Source = localhost; Port = 3306 ; Initial Catalog = rezept; User Id = Benex; Password = 111111;");

                con = new MySqlConnection(connection);

                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = _sql;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private List<Zutaten> ReadZutaten(string _sql)
        {
            List<Zutaten> z = new List<Zutaten>();

            if (sqlConnection(_sql))
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                       z.Add(new Zutaten(reader.GetString("G_Name"), reader.GetDouble("Alk")));
                    }
                }
            }
            con.Close();
            return z;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + Environment.NewLine;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool isCellChecked = false;
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    isCellChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value);
                }

                if (isCellChecked)
                {
                    s += dataGridView1.Rows[i].Cells[0].Value + " | " + dataGridView1.Rows[i].Cells[1].Value + "% | " + dataGridView1.Rows[i].Cells[2].Value + "cl " + Environment.NewLine;
                }
                
            }
            dataGridView1.EndEdit();

            MessageBox.Show(s);
        }
    }
}