namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Igrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} es par");
            }
            else
            {
                Console.WriteLine($"{numero} es impar");
            }
        }
    }
}
