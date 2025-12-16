namespace classes_Hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Greetings greetings = new Greetings();
            greetings.Welcome();

            // Ask the user for their name
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();

            greetings.Hello(userName);

        }
    }
}
