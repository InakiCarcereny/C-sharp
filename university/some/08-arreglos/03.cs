namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres;

            string nombre_a_buscar;

            int contador;

            const int cantidad_nombres;

            bool encontrado;

            encontrado = false;
            cantidad_nombres = 5;
            contador = 0;

            nombres = new string[cantidad_nombres];

            for (int i = 0; i < cantidad_nombres; i++)
            {
                Console.WriteLine($"Ingrese el nombre numero {i + 1}");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el nombre a buscar");
            nombre_a_buscar = Console.ReadLine();

            for (int i = 0; i <= nombres.Length - 1; i++)
            {
                if (nombre_a_buscar == nombres[i])
                {
                    encontrado = true;
                    Console.WriteLine($"El nombre {nombre_a_buscar} se encuntra en la posicion {contador}");
                }

                contador++;
            }
        }
    }
}
