namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            const int CANTIDAD_NUMEROS = 10;

            int numero_actual;

            bool exito,
                 repetido;

            numeros = new int[CANTIDAD_NUMEROS];
            repetido = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el numero {i + 1}");
                    exito = int.TryParse(Console.ReadLine(), out numeros[i]);
                } while (!exito || numeros[i] < 0);
            }

            numero_actual = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero_actual)
                {
                    repetido = true;
                }

                numero_actual = numeros[i];
            }

            if (repetido)
            {
                Console.WriteLine("Hay valores duplicados en el arreglo");
            }
            else
            {
                Console.WriteLine("No hay valores duplicados en el arreglo");
            }
        }
    }
}
