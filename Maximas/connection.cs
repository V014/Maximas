using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Maximas
{
    class connection
    {
        // declare connection variables
        private static SQLiteConnection con;
        private static SQLiteCommand cmd;
        private static DataSet DS = new DataSet();
        private static DataTable DT = new DataTable();

        // connection to database file
        private static void setConnection()
        {
            con = new SQLiteConnection("Data Source=Maximas.db;Version=3;New=Flase;Compress=True;");
        }
        // execute query function
        public static void ExecuteQuery(string txtQuery)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // opens connection
        public static SQLiteConnection GetConnection()
        {
            setConnection();
            con.Open();
            return con;
        }
        // pulls data in single string
        public static string ReadString(string txtQuery)
        {
            using(SQLiteConnection con = GetConnection())
            using (SQLiteCommand cmd = new SQLiteCommand(txtQuery, con))
            {
                object result = cmd.ExecuteScalar();
                return (result == null ? "" : result.ToString());
            }
        }
        //loads data into a data grid
        public void LoadData(string query, DataGridView dataGrid)
        {
            var con = connection.GetConnection();
            var DB = new SQLiteDataAdapter(query, con);
            var DS = new DataSet();
            var DT = new DataTable();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGrid.DataSource = DT;
            con.Close();
        }
    }
}
