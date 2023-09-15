using Microsoft.Data.SqlClient;

namespace MicrosoftSqlServer.EF.Connection.Example.Raw
{
    internal class Connection
    {
        private static readonly string Server = "localhost";
        private static readonly string User = "sa";
        private static readonly string DBname = "AdventureWorks2019";
        private static readonly string Password = "blog_6109";
        private SqlConnection? Cnn {  get; set; }

        public void Open()
        {
            Cnn = new SqlConnection(string.Format(
                    "Server={0};User Id={1};Database={2};Password={3};TrustServerCertificate=True",
                    Server,
                    User,
                    DBname,
                    Password));

            Cnn.Open();
        }

        public void Query()
        {
            string sql = "SELECT name, collation_name FROM sys.databases";

            using SqlCommand command = new(sql, Cnn);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            }
        }

        public void Close()
        {
            Cnn?.Close();
        }
    }
}
