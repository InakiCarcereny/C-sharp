namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put a message: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
        }
    }
}
