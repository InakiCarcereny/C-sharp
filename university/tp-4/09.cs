namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_anterior = 0;
            int numero_actual = 0;
            bool secuencia_ordenada = true;
            bool exito = true;

            Console.WriteLine("Ingrese números positivos uno por uno. Ingrese 0 para terminar.");

            while (exito)
            {
                Console.Write("Ingrese un número: ");
                 exito = int.TryParse(Console.ReadLine(), out numero_actual);

                if (!exito || numero_actual < 0)
                {
                    Console.WriteLine("Número inválido. Intente nuevamente.");
                    continue;
                }

                if (numero_actual == 0)
                {
                    break;
                }

                if (numero_anterior > 0 && numero_actual < numero_anterior)
                {
                    secuencia_ordenada = false;
                }

                numero_anterior = numero_actual;
            }

            if (secuencia_ordenada)
            {
                Console.WriteLine("La secuencia está ordenada de forma creciente.");
            }
            else
            {
                Console.WriteLine("La secuencia NO está ordenada.");
            }
        }
    }
}
