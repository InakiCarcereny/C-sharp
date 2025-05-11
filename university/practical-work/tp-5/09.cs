namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            const int CANTIDAD_NUMEROS = 10;

            bool exito;

            int cantidad_numeros_1,
                cantidad_numeros_2,
                cantidad_numeros_3,
                cantidad_numeros_4,
                cantidad_numeros_5;


            numeros = new int[CANTIDAD_NUMEROS];

            cantidad_numeros_1 = 0;
            cantidad_numeros_2 = 0;
            cantidad_numeros_3 = 0;
            cantidad_numeros_4 = 0;
            cantidad_numeros_5 = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese numeros entre 1 y 5 inclusive");
                    exito = int.TryParse(Console.ReadLine(), out numeros[i]);
                } while (!exito || numeros[i] < 1 || numeros[i] > 5);
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 1)
                {
                    cantidad_numeros_1++;
                }

                if (numeros[i] == 2)
                {
                    cantidad_numeros_2++;
                }

                if (numeros[i] == 3)
                {
                    cantidad_numeros_3++;
                }

                if (numeros[i] == 4)
                {
                    cantidad_numeros_4++;
                }

                if (numeros[i] == 5)
                {
                    cantidad_numeros_5++;
                }
            }

            Console.WriteLine($"Aparecio {cantidad_numeros_1} veces el numero 1");
            Console.WriteLine($"Aparecio {cantidad_numeros_2} veces el numero 2");
            Console.WriteLine($"Aparecio {cantidad_numeros_3} veces el numero 3");
            Console.WriteLine($"Aparecio {cantidad_numeros_4} veces el numero 4");
            Console.WriteLine($"Aparecio {cantidad_numeros_5} veces el numero 5");
        }
    }
}
