namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_pisos;

            Console.WriteLine("Cuantos pisos queres que tenga la piramide?");
            numero_pisos = int.Parse(Console.ReadLine());

            for (int i = numero_pisos; i > 0; i--)
            {
                Console.WriteLine();

                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write('*');
                }
            }
        }
    }
}
