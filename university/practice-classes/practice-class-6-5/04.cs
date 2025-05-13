namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tiempos;

            int suma,
                promedio,
                mas_de_30min,
                tiempo_mas_largo,
                indice_tiempo_mas_largo;

            string[] nombres;

            bool exito;

            tiempos = new int[3];
            nombres = new string[3];

            suma = 0;
            promedio = 0;
            mas_de_30min = 0;

            tiempo_mas_largo = tiempos[0];
            indice_tiempo_mas_largo = 0;

            for (int i = 0; i < tiempos.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el tiempo de espera del {i + 1} paciente");
                    exito = int.TryParse(Console.ReadLine(), out tiempos[i]);

                    suma += tiempos[i];
                    promedio = suma / tiempos.Length;

                    if (tiempos[i] >= 30)
                    {
                        mas_de_30min++;
                    }

                    if (tiempos[i] > tiempo_mas_largo)
                    {
                        tiempo_mas_largo = tiempos[i];
                        indice_tiempo_mas_largo = i;
                    }
                } while (!exito);
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre del paciente {i + 1}");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine($"El tiempo promedio fue {promedio}");

            Console.WriteLine($"La cantidad de pacientes que esperaron mas de 30 min fueron {mas_de_30min}");

            Console.WriteLine($"El tiempo mas largo fue de {tiempo_mas_largo} min y se encuentra en la posicion {indice_tiempo_mas_largo}");
        }
    }
}
