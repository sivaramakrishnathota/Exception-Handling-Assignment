namespace MultiThreadingExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread backgroundThread = new Thread(PerformBackgroundTask);
            backgroundThread.Start();

            //thread join is used when i want to block my thread untill another thread finishes.
            backgroundThread.Join();
            Console.WriteLine("Program execution continue");
        }
        public static void PerformBackgroundTask()
        {
            try
            {
                Console.WriteLine("Background task started");
                Thread.Sleep(2000);
                string input = "kjsnf";
                int number = Convert.ToInt32(input);
                Console.WriteLine("Background task completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in background thread: " + ex.Message);
            }
        }
    }
}