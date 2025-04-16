namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Ingrese un valor");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El 30% de {x} es {(x * 30) / 100}");
        }
    }
}
