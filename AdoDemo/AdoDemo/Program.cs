using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

string connectionString = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;

using (MySqlConnection connection = new MySqlConnection(connectionString))
{
    Console.WriteLine("正在连接数据库...");
    connection.Open();
    Console.WriteLine("连接成功！");
    var siteNmae = ConfigurationManager.AppSettings["siteName"];
    Console.WriteLine(siteNmae);


    
}