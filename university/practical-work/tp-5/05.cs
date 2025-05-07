namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros,
                  numeros_2,
                  numeros_sumados;

            int numero;

            const int CANTIDAD_NUMEROS = 8;

            numeros = new int[CANTIDAD_NUMEROS];
            numeros_2 = new int[CANTIDAD_NUMEROS];
            numeros_sumados = new int[CANTIDAD_NUMEROS];

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numero = aleatorio.Next(3, 58);
                numeros[i] = numero;
            }

            for (int i = 0; i < numeros_2.Length; i++)
            {
                numero = aleatorio.Next(3, 58);
                numeros_2[i] = numero;
            }

            for (int i = 0; i < numeros_sumados.Length; i++)
            {
                numeros_sumados[i] = numeros[i] + numeros_2[i];
            }

            Console.Write(string.Join(", ", numeros));

            Console.WriteLine();

            Console.Write(string.Join(", ", numeros_2));

            Console.WriteLine();

            Console.Write(string.Join(", ", numeros_sumados));
        }
    }
}
