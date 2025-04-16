namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad_valores,
                valores,
                suma;


            double promedio;

            suma = 0;
            promedio = 0;

            Console.WriteLine("Cuantos valores quiere ingresar");
            cantidad_valores = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad_valores; i++)
            {
                Console.WriteLine("Ingrese un valor");
                valores = Convert.ToInt32(Console.ReadLine());

                suma = suma + valores;

                promedio = (double) suma / cantidad_valores;
            }

            Console.WriteLine($"La suma total es {suma}");
            Console.WriteLine($"El promedio es {promedio}");
        }
    }
}
