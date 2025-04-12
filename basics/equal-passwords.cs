namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password_1,
                   password_2;

            Console.WriteLine("Enter a password");
            password_1 = Console.ReadLine();

            Console.WriteLine("Enter the password again");
            password_2 = Console.ReadLine();

            if (!password_1.Equals(string.Empty) && !password_2.Equals(string.Empty))
            {
                if (password_1.Equals(password_2))
                {
                    Console.WriteLine("Passwords match");
                }
                else
                {
                    Console.WriteLine("Passwords do not match");
                }
            }
            else 
            {
                Console.WriteLine("Please enter a password");
            }
        }
    }
}
