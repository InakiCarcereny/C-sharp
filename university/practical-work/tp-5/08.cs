namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros,
                  numeros_sin_eliminado;

            const int CANTIDAD_NUMEROS = 10;

            int numero_a_buscar,
                j;

            bool exito,
                 existe_numero_array,
                 eliminado;

            numeros = new int[CANTIDAD_NUMEROS];

            existe_numero_array = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el numero {i + 1}");
                    exito = int.TryParse(Console.ReadLine(), out numeros[i]);
                } while (!exito);
            }

            do
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write($"{numeros[i]}, ");
                }
                Console.WriteLine();

                Console.WriteLine("Ingrese un numero que desea eliminar");
                numero_a_buscar = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == numero_a_buscar)
                    {
                        existe_numero_array = true;
                    }
                }

                if (!existe_numero_array)
                {
                    Console.WriteLine("El numero no existe en el arreglo, ingrese otro");
                }
            } while (!existe_numero_array);

            numeros_sin_eliminado = new int[CANTIDAD_NUMEROS - 1];

            eliminado = false;
            j = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero_a_buscar && !eliminado)
                {
                    eliminado = true;
                    continue;
                }
                else
                {
                    numeros_sin_eliminado[j] = numeros[i];
                    j++;
                }
            }

            Console.WriteLine("El arreglo final es");

            for (int i = 0; i < numeros_sin_eliminado.Length; i++)
            {
                Console.Write($"{numeros_sin_eliminado[i]}, ");
            }
        }
    }
}
