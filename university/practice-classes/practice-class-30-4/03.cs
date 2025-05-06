namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] precios;

            bool exito,
                 esta_ordenada;

            int cantidad_precios;

            esta_ordenada = true;

            do
            {
                Console.WriteLine("Cuantos precios desea cargar");
                exito = int.TryParse(Console.ReadLine(), out cantidad_precios);
            } while (!exito || cantidad_precios <= 0);

            precios = new double[cantidad_precios];

            for (int i = 0; i < precios.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el precio {i + 1}");
                    exito = double.TryParse(Console.ReadLine(), out precios[i]);
                } while (!exito || precios[i] <= 0);
            }

            for (int i = 0; i < precios.Length - 1; i++)
            {
                if (precios[i] > precios[i + 1])
                {
                    esta_ordenada = false;
                }
            }

            if (esta_ordenada)
            {
                Console.WriteLine("La lista esta ordenada");
            }
            else
            {
                Console.WriteLine("La lista esta desordenada");
            }
        }
    }
}
