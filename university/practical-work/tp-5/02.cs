namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            bool exito;

            int numero,
                contador;

            const int CANTIDAD_NUMEROS = 10;

            numeros = new int[CANTIDAD_NUMEROS];
            contador = 0;

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numero = aleatorio.Next(1, 101);
                numeros[i] = numero;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 50)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Hay {contador} numeros mayor a 50");
        }
    }
}
