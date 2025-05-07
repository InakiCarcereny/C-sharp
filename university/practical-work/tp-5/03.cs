namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            int numero,
                suma,
                promedio,
                contador;

            const int CANTIDAD_NUMEROS = 20;

            numeros = new int[CANTIDAD_NUMEROS];
            suma = 0;
            contador = 0;
            promedio = 0;

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numero = aleatorio.Next(1, 101);
                numeros[i] = numero;
                suma += numeros[i];
            }

            promedio = suma / numeros.Length;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > promedio)
                {
                    contador++;
                }
            }

            Console.Write($"Arreglo generado: {string.Join(", ", numeros)}");

            Console.WriteLine();

            Console.WriteLine($"El promedio de todos los numeros es {promedio}");
            Console.WriteLine($"Hay {contador} numeros mayores al promedio");
        }
    }
}
