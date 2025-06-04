namespace Clase_4_6_BusquedaBnaria
{
    internal class Program
    {

        static void OrdenarBurbujaCreciente(int[] aNumeros)
        {
            for (int i = 0; i < aNumeros.Length - 1; i++)
            {
                for (int j = 0; j < aNumeros.Length - 1; j++)
                {
                    if (aNumeros[j] > aNumeros[j + 1])
                    {
                        int aux = aNumeros[j];
                        aNumeros[j] = aNumeros[j + 1];
                        aNumeros[j + 1] = aux;
                    }
                }
            }
        }

        static int BusquedaBinaria(int[] aNumeros, int numBuscado)
        {
            int inicio = 0;
            int fin = aNumeros.Length - 1;
            int indiceEncontrado = -1;
            int contador = 0;

            while (inicio <= fin && indiceEncontrado == -1)
            {
                int medio = (inicio + fin) / 2;

                contador++;

                if (aNumeros[medio] == numBuscado)
                {
                    indiceEncontrado = medio;
                }
                else if (aNumeros[medio] < numBuscado)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            Console.WriteLine($"La búsqueda llevó {contador} comparaciones.");

            return indiceEncontrado;
        }

        static void MostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine(" 1- ver listado de tarjetas habilitadas.");
            Console.WriteLine(" 2- Consultar una tarjeta.");
            Console.WriteLine(" 0- Salir");
            Console.ResetColor();
        }

        static void MostrarListadoTarjetas(int[] aTarjetas)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            for (int i = 0; i < aTarjetas.Length; i++)
            {
                Console.WriteLine(aTarjetas[i]);
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        static int PedirNumeroEnteroPositivo(string mensaje)
        {
            int resultado;

            Console.Write(mensaje);
            
            while (!int.TryParse(Console.ReadLine(), out resultado) || resultado <1)
            {
                Console.WriteLine("El valor ingresado es inválido.");
                Console.Write(mensaje);
            }
            return resultado;
        }

        static void VerificarTarjeta(int[] aTarjetas)
        {
            int tarjetaBuscada = PedirNumeroEnteroPositivo("Ingrese el numero de tarjeta a verificar: ");
            
            if (BusquedaBinaria(aTarjetas, tarjetaBuscada) != -1)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Tarjeta habilitada! =)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tarjeta NO habilitada! =(");
                Console.ResetColor();
            }

        }

        static void Main(string[] args)
        {
            int[] aTarjetasHabilitadas = new int[20] { 12123, 25896, 45687, 25478, 25689, 11111, 22222, 131313, 33333, 44444, 55555, 66666, 77777, 88888, 99999, 101010, 121212, 151515, 161616, 12345 };

            OrdenarBurbujaCreciente(aTarjetasHabilitadas);

            string opcion;
            
            do
            {
                MostrarMenu();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        MostrarListadoTarjetas(aTarjetasHabilitadas);
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        VerificarTarjeta(aTarjetasHabilitadas);
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (opcion != "0");
        }
    }
}
