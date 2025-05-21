namespace sum_two_numbers
{
    internal class Program
    {
        static int[] ObtenerValores()
        {
            bool exito;

            int[] notas;

            const int CANTIDAD_NOTAS = 10;

            notas = new int[CANTIDAD_NOTAS];

            for (int i = 0; i < notas.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese la nota {i + 1}");
                    exito = int.TryParse(Console.ReadLine(), out notas[i]);
                } while (!exito || notas[i] < 0 || notas[i] > 100);
            }

            return notas;
        }

        static string[] ObtenerNombres()
        {
            string[] nombres;

            const int CANTIDAD_NOMBRES = 10;

            nombres = new string[CANTIDAD_NOMBRES];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre {i + 1}");
                nombres[i] = Console.ReadLine();
            }

            return nombres;
        }

        static void MostrarDatos(string[] nombres, int[] notas)
        {
            Console.WriteLine("Listado de nombres y notas:");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{nombres[i]}: {notas[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] notas;
            string[] nombres;

            notas = ObtenerValores();

            nombres = ObtenerNombres();

            MostrarDatos(nombres, notas);
        }
    }
}
