namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,
                num2;

            Console.WriteLine("Ingrese un numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La suma de los numero es {num1 + num2}");
        }
    }
}
