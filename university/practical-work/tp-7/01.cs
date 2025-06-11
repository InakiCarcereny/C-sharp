namespace sum_two_numbers
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("1 - Comenzar nueva partida");
            Console.WriteLine("2 - Ingresar el numero");
            Console.WriteLine("3 - Salir");
        }
        static void CargarValoresAleatorios(int[] numeros)
        {
            int numero;

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numero = aleatorio.Next(1, 10001);
                numeros[i] = numero;
            }

            OrdenarArreglo(numeros);
        }

        static void OrdenarArreglo(int[] numeros)
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
        }

        static int BuscarNumero(int[] numeros)
        {
            int inicio = 0;
            int fin = numeros.Length - 1;
            int indice = -1;

            int numero_objetivo;

            bool exito;

            do
            {
                Console.WriteLine("Ingrese el numero a buscar, tiene que estar entre 1 y 1000");
                exito = int.TryParse(Console.ReadLine(), out numero_objetivo);
            } while (!exito || numero_objetivo < 1 || numero_objetivo > 1000);

            while (inicio <= fin && indice == - 1)
            {
                int medio = (inicio + fin) / 2;

                if (numeros[medio] == numero_objetivo)
                {
                    indice = medio;
                }
                else if (numeros[medio] <  numero_objetivo)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return indice;
        }

        static void Main(string[] args)
        {
            int[] numeros;

            string respuesta;

            int numero;

            const int CANTIDAD_NUMEROS = 20;

            numeros = new int[CANTIDAD_NUMEROS];

            do
            {
                Console.Write("Bienvenido al juego, elija una de las siguientes opciones: ");
                Console.WriteLine();
                Menu();

                respuesta = Console.ReadLine();

                switch(respuesta)
                {
                    case "1": CargarValoresAleatorios(numeros);
                        break;
                    case "2": numero = BuscarNumero(numeros);
                        if (numero != -1)
                        {
                            Console.WriteLine($"Felicidades encontro el numero {respuesta} en la posicion {numero}");
                        }
                        else
                        {
                            Console.WriteLine("Intente nuevamente");
                        }
                            break;
                    case "3": Console.WriteLine("Saliendo...");
                        break;
                }
            } while (respuesta != "3");
        }
    }
}
