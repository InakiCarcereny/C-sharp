namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,
                b,
                c;

            Console.WriteLine("Ingrese un numero");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un ultimo numero");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a - b) > c)
            {
                Console.WriteLine($"El producto entre {a} y {b} es {a * b}");
            }
            else
            {
                Console.WriteLine($"El cociente entre {a} y {b} es {a / b}");
            }
        }
    }
}
