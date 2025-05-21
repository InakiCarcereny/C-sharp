namespace sum_two_numbers
{
    internal class Program
    {
        static int[] ObtenerValores()
        {
            int[] valores;

            int numero;

            const int CANTIDAD_VALORES = 100;

            valores = new int[CANTIDAD_VALORES];

            Random aleatorio = new Random();

            for (int i = 0; i < valores.Length; i++)
            {
                numero = aleatorio.Next(0, 11);

                valores[i] = numero;
            }

            return valores;
        }

        static int[] contadores = new int[10];

        static void ContarRespuestas(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                int valor = valores[i];

                if (valor >= 1 && valor <= 10)
                {
                    contadores[valor - 1]++;
                }
            }

            Console.WriteLine("Cantidad de veces que se eligió cada respuesta:");

            for (int i = 0; i < contadores.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {contadores[i]}");
            }
        }

        static int ValorMasFrecuente()
        {
            int contador_mas_alto = contadores[0];

            for (int i = 0; i < contadores.Length; i++)
            {
                if (contadores[i] > contador_mas_alto)
                {
                    contador_mas_alto = contadores[i];
                }
            }

            return contador_mas_alto;
        }

        static void Main(string[] args)
        {
            int[] valores;

            int contador_mas_alto;

            valores = ObtenerValores();

            ContarRespuestas(valores);

            contador_mas_alto = ValorMasFrecuente();

            Console.WriteLine($"El numero que mas se repite es {contador_mas_alto}");
        }
    }
}
