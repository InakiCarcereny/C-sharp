namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero,
                suma,
                cantidad_numeros;

            double promedio;

            bool exito;

            numero = 0;
            promedio = 0;
            cantidad_numeros = 0;
            suma = 0;
            exito = true;

            while (exito == true)
            {
                Console.WriteLine("Ingrese un valor");
                exito = int.TryParse(Console.ReadLine(), out numero) && numero > 0;

                cantidad_numeros++;

                suma = suma + numero;

                promedio = (double)suma / cantidad_numeros;

                if (numero < 0)
                {
                    exito = false;
                }
            }

            Console.WriteLine($"La cantidad de numero es {cantidad_numeros}");
            Console.WriteLine($"El promedio es {promedio:F2}");
        }
    }
}
