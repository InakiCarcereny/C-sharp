namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            int suma;

            const int cantidad_numeros;

            bool exito;

            cantidad_numeros = 5;
            suma = 0;

            numeros = new int[cantidad_numeros];

            for (int i = 0; i < cantidad_numeros; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el numero {i + 1}");
                    exito = int.TryParse(Console.ReadLine(), out numeros[i]);
                } while (!exito || numeros[i] <= 0);

                if (exito)
                {
                    suma += numeros[i];
                }
            }

            Console.WriteLine($"La suma total de los numeros es: {suma}");
        }
    }
}
