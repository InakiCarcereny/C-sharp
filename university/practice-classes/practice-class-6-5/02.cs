namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] temperaturas;

            bool exito;

            double suma,
                   promedio_semana,
                   promedio_dia,
                   minima,
                   maxima;

            int cantidad_temperaturas_menor,
                indice_minima,
                indice_maxima;

            temperaturas = new double[7,2];
            suma = 0;
            cantidad_temperaturas_menor = 0;
            indice_minima = 0;
            indice_maxima = 0;

            for (int i = 0; i < 7; i++)
            {
               do
               {
                   Console.WriteLine($"Ingrese la temperatura maxima del {i + 1} dia");
                   exito = double.TryParse(Console.ReadLine(), out temperaturas[i, 0]);
               } while (!exito)

               do
               {
                   Console.WriteLine($"Ingrese la temperatura minima del {i + 1} dia");
                   exito = double.TryParse(Console.ReadLine(), out temperaturas[i, 1]);
               } while (!exito)
            }

            for (int i = 0; i < 7; i++)
            {
                suma += (temperaturas[i, 0] + temperaturas[i, 1]) / 2;
            }

            promedio_semana = suma / 7;

            Console.WriteLine($"La media de las temperaturas es: {promedio_semana}");

            maxima = temperaturas[0, 0];
            minima = temperaturas[0, 1];

            for (int i = 0; i < 7; i++)
            {
                promedio_dia = (temperaturas[i, 0] + temperaturas[i, 1]) / 2;

                if (promedio_dia < promedio_semana)
                {
                    cantidad_temperaturas_menor++;
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i, 0] > maxima)
                {
                    maxima = temperaturas[i, 0];
                    indice_maxima = i;
                }

                if (temperaturas[i, 1] < minima)
                {
                    minima = temperaturas[i, 1];
                    indice_minima = i;
                }
            }

            Console.WriteLine($"La temperatura maxima es: {maxima} y fue el dia {indice_maxima + 1}");

            Console.WriteLine($"La temperatura minima es: {minima} y fue el dia {indice_minima + 1}");

            Console.WriteLine($"Hubo {cantidad_temperaturas_menor} dias con temperatura menor al promedio semanal");
        }
    }
}