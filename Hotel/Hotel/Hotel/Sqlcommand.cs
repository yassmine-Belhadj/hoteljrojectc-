using System.Data.SqlClient;

namespace Hotel
{
    internal class Sqlcommand
    {
        private string v;
        private SqlConnection con;

        public Sqlcommand(string v, SqlConnection con)
        {
            this.v = v;
            this.con = con;
        }
    }
}