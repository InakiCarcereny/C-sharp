namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba";
            int age = 23;

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.WriteLine($"Your name is {name} and your age is {age}");
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);

            string test = string.Concat("your name is ", name, " and your age is", age);

            string[] names = new string[] { "Aba ", "Test ", "Test" };
            Console.WriteLine(string.Concat(names));

        }
    }
}
