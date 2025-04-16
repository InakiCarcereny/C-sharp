namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_pisos;

            Console.WriteLine("Cuantos pisos queres que tenga la piramide?");
            numero_pisos = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numero_pisos; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
            }
        }
    }
}
