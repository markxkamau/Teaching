using System.Data.SqlClient;

class Program
{
    SqlConnection connection = new SqlConnection("Host=localhost; Database=Banking_Sys; Username=root; Password=password;");
    // Find in file.txt created on ur end
    public void getConnection()
    {
        if (connection.ConnectionString != null)
        {
            Console.WriteLine("Connection to db successfull");

        }
        else
        {
            Console.WriteLine("Connection to db unsuccessfull");

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
}