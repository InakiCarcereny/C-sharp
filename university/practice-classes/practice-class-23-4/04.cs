namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;

            bool exito;

            altura = 0;
            exito = false;

            while (!exito || altura < 1)
            {
                Console.WriteLine("Ingrese una altura");
                exito = int.TryParse(Console.ReadLine(), out altura);
            }

            for (int i = 0; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}
