namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tiempos;

            bool exito;

            int suma,
                mejor_marca,
                peor_marca;

            double promedio;

            tiempos = new int[5];

            suma = 0;

            for (int i = 0; i < tiempos.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese la marca {i + 1}");
                    exito = int.TryParse( Console.ReadLine(), out tiempos[i]);
                } while (!exito || tiempos[i] <= 0);

                suma += tiempos[i];
            }

            promedio = (double)suma / tiempos.Length;

            mejor_marca = tiempos[0];
            peor_marca = tiempos[0];

            for (int i = 1; i < tiempos.Length; i++)
            {
                if (tiempos[i] < mejor_marca)
                {
                    mejor_marca = tiempos[i];
                }

                if (tiempos[i] > peor_marca)
                {
                    peor_marca = tiempos[i];
                }
            }

            Console.WriteLine($"El promedio de todos los tiempos fue {promedio}");

            Console.WriteLine($"El mejor tiempo fue {mejor_marca}");

            Console.WriteLine($"El peor tiempo fue {peor_marca}");
        }
    }
}
