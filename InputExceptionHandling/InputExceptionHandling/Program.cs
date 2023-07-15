namespace InputExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string str = "sfkldl";
                int number = Convert.ToInt32(str);
                Console.WriteLine("Valid input: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input Please enter a numeric value.");
            }

            Console.WriteLine("Program execution continues...");
        }
    }
}