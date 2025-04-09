namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1,
                   lado2,
                   lado3;

            Console.WriteLine("Ingrese un lado");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese otro lado");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un ultimo lado");
            lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Equilátero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Isósceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
        }
    }
}
