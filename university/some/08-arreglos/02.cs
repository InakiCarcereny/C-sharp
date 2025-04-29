namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            const int cantidad_numeros;

            bool exito;

            cantidad_numeros = 10;

            numeros = new int[cantidad_numeros];

            for (int i = 0; i < cantidad_numeros; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el numero {i + 1}");
                    exito = int.TryParse(Console.ReadLine(), out numeros[i]);
                } while (!exito || numeros[i] <= 0);
            }

            Console.WriteLine();

            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"El numero en la posicion {i + 1} es: {numeros[i]}");
            }
        }
    }
}
