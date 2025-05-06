namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1,
                numero2,
                numero3;

            Console.WriteLine("Ingrese un numero");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un ultimo numero");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2 && numero2 > numero3)
            {
                Console.WriteLine($"{numero1}, es el mas grande");
            }

            if (numero2 > numero1 && numero1 > numero3)
            {
                Console.WriteLine($"{numero2}, es el mas grande");
            }

            if (numero3 > numero1 && numero1 > numero2)
            {
                Console.WriteLine($"{numero3}, es el mas grande");
            }
        }
    }
}
