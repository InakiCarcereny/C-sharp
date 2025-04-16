namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_pisos;

            Console.WriteLine("Cuantos pisos queres que tenga la piramide?");
            numero_pisos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero_pisos; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (int i = numero_pisos - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
