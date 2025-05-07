namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros,
                  numeros_inversos;

            int numero;

            const int CANTIDAD_NUMEROS = 8;

            numeros = new int[CANTIDAD_NUMEROS];
            numeros_inversos = new int[CANTIDAD_NUMEROS];

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numero = aleatorio.Next(1, 101);
                numeros[i] = numero;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros_inversos[i] = numeros[numeros.Length - 1 - i];
            }

            Console.Write($"El primer arreglo: {string.Join(", ", numeros)}");

            Console.WriteLine();

            Console.Write($"El arreglo invertido: {string.Join(", ", numeros_inversos)}");
        }
    }
}
