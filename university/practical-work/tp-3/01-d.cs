namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1,
                numero2;

            Console.WriteLine("Ingrese un numero");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"{numero1} es mayor a {numero2}");
            }
            else
            {
                Console.WriteLine($"{numero2} es mayora a {numero1}");
            }
        }
    }
}
