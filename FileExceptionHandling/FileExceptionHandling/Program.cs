namespace FileExceptionHandling
{
    public class Program
    {
        public static void Main()
        {
            string filePath = @"C:\Users\Siva Thota\Desktop\topics.txt";

            try
            {
                // Attempt to read data from the file
                string[] lines = File.ReadAllLines(filePath);

                // process the data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("File processing completed successfully.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.FileName);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            Console.WriteLine("Program execution continues...");
        }
    }
}