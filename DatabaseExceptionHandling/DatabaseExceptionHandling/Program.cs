using System.Data.SqlClient;  //Here we should install the package of Data.Sqlclient
namespace DatabaseExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = @"Data Source=192.168.0.30;Initial Catalog=siva;Persist Security Info=True;User ID=User5;Password=CDev005#8";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Perform database operations
                    string query = "SELECT * FROM main";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("hello world");
                    // Process the query results
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        Console.WriteLine($"Customer_id: {id}, name : {name}");
                    }
                    // Close the reader
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL-related exceptions
                Console.WriteLine("SQL Exception occurred: " + ex.Message);
                // Log the exception or perform any other necessary actions
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Exception occurred: " + ex.Message);
                // Log the exception or perform any other necessary actions
            }
            Console.WriteLine("Program execution continues...");
        }
    }
}