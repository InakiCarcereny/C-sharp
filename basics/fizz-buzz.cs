namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool three_div = false;
            bool five_div = false;

            for (int i = 1; i <= 15; i++)
            {
                three_div = i % 3 == 0;
                five_div = i % 5 == 0;

                if (three_div && five_div)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (three_div)
                {
                    Console.WriteLine("Fizz");
                }
                else if (five_div)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
