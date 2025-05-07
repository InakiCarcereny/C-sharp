namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            bool exito,
                 encontrado;

            int numero_a_buscar,
                numero,
                posicion;

            const int CANTIDAD_NUMEROS = 10;

            numeros = new int[CANTIDAD_NUMEROS];

            Random aleatorio = new Random();

            encontrado = false;
            posicion = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numero = aleatorio.Next(1, 21);
                numeros[i] = numero;
            }

            do
            {
                do
                {
                    Console.WriteLine("Ingrese el numero que quiere buscar");
                    exito = int.TryParse(Console.ReadLine(), out numero_a_buscar);
                } while (!exito || numero_a_buscar < 0);

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == numero_a_buscar)
                    {
                        encontrado = true;
                        posicion = i;
                        Console.WriteLine($"El numero {numero_a_buscar} se encontro en la posicion {posicion}");
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("El numero no se encuentra en el array");
                }
            } while (numero_a_buscar > 0);
        }
    }
}
