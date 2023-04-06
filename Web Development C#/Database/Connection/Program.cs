using System.Data.SqlClient;
// Add from terminal using 
// dotnet add package System.Data.SqlClient
// Method 2 
// nuget packages
// find the package and install System.Data.SqlClient

class Program
{
    public static void Main(string[] args)
    {
        SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DatabaseName;User Id=myUsername;Password=myPassword;");    // Find in file.txt created on ur end
        if (connection.ConnectionString != null)
        {
            Console.WriteLine("Connection to db successfull");

        }
        else
        {
            Console.WriteLine("Connection to db unsuccessfull");

        }
    }


    // SqlCommand command = new SqlCommand("SELECT * FROM myTable", connection);
    // SqlDataReader reader = command.ExecuteReader();
    // while (reader.Read())
    // {
    //     Console.WriteLine(reader.GetString(0));
    // }
    // reader.Close();
    // connection.Close();

}