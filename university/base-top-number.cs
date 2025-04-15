namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int base_num,
                tope_num;

            Console.WriteLine("Ingrese un numero base");
            base_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero tope");
            tope_num = Convert.ToInt32(Console.ReadLine());

            while (base_num <= tope_num)
            {
                Console.WriteLine($"El numero actual es: {base_num}");
                base_num = base_num + 1;
            }
        }
    }
}
