namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longitud;
            int[,] aMatriz;


            Console.Write("Ingrese la longitud: ");

            while (!int.TryParse(Console.ReadLine(), out longitud) || longitud < 0)
            {
                Console.WriteLine("Mal ingreso, ingresar entero positivo: ");
            }

            aMatriz = new int[longitud, longitud];

            for (int i = 0; i < longitud; i++)
            {
                for (int j = 0; j < longitud; j++)
                {
                    if(i + 1 == j + 1)
                    {
                        aMatriz[i, j] = i + 1;
                    } else
                    {
                        aMatriz[i, j] = 0;
                    }

                    Console.Write(aMatriz[i, j] + " ");
                }

              Console.WriteLine();
            }
        }
    }
}