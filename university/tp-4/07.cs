namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largo,
                alto;

            Console.WriteLine("Ingrese un alto");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un largo");
            largo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < largo; j++)
                {
                    if (i == 0 || i == alto - 1 || j == 0 || j == largo - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
