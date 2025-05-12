namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades,
                  edades_extendido;

            int recaudacion_total,
                cantidad_personas_menores_12,
                cantidad_personas_entre_12_64,
                cantidad_personas_mayores_64,
                contador,
                edad;

            const int CANTIDAD_EDADES = 5;

            bool exito;

            edades = new int[CANTIDAD_EDADES];

            contador = 0;
            recaudacion_total = 0;

            cantidad_personas_menores_12 = 0;
            cantidad_personas_entre_12_64 = 0;
            cantidad_personas_mayores_64 = 0;

            do
            {
                do
                {
                    Console.WriteLine($"Ingrese la edad de la persona numero {contador + 1} o negativa para terminar");
                    exito = int.TryParse(Console.ReadLine(), out edad);
                } while (!exito);

                if (contador == edades.Length)
                {
                    edades_extendido = new int[edades.Length + CANTIDAD_EDADES];

                    for (int i = 0; i < edades.Length; i++)
                    {
                        edades_extendido[i] = edades[i];
                    }

                    edades = edades_extendido;
                }

                edades[contador] = edad;
                contador++;
            } while (edad > 0);

            for (int i = 0; i < contador; i++)
            {
                if (edades[i] > 0 && edades[i] <= 12)
                {
                    cantidad_personas_menores_12++;
                    recaudacion_total += 1500;
                }
                
                if (edades[i] > 12 && edades[i] <= 64)
                {
                    cantidad_personas_entre_12_64++;
                    recaudacion_total += 2500;
                }
                
                if (edades[i] > 64)
                {
                    cantidad_personas_mayores_64++;
                    recaudacion_total += 2000;
                }
            }

            if (cantidad_personas_menores_12 > cantidad_personas_mayores_64 && cantidad_personas_menores_12 > cantidad_personas_entre_12_64)
            {
                Console.WriteLine("La entrada mas vendida fue la de menores de a 12 anios");
            }
            else if (cantidad_personas_mayores_64 > cantidad_personas_menores_12 && cantidad_personas_mayores_64 > cantidad_personas_entre_12_64)
            {
                Console.WriteLine("La entrada mas vendida fue la de mayores a 64 anios");
            }
            else
            {
                Console.WriteLine("La entrada mas vendida fue la de entre 12 y 64 anios");
            }

            Console.WriteLine($"La recaudacion total fue de ${recaudacion_total}");

            Console.WriteLine($"Hubieron {cantidad_personas_menores_12} entradas a menores de 12 anios");
            Console.WriteLine($"Hubieron {cantidad_personas_entre_12_64} entradas a mayores de 12 y menores de 64 anios");
            Console.WriteLine($"Hubieron {cantidad_personas_mayores_64} entradas a mayores de 64 anios");
        }
    }
}
