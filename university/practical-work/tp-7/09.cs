namespace sum_two_numbers
{
    internal class Program
    {
        public struct Juego
        {
            public string nombre;
            public int cantidad_minima;
            public int cantidad_maxima;
            public int duracion;
        }

        static void Menu()
        {
            Console.WriteLine("\n--- MENÚ DEL TORNEO LÚDICO ---");
            Console.WriteLine("1. Cargar juegos");
            Console.WriteLine("2. Mostrar todos los juegos cargados");
            Console.WriteLine("3. Listar juegos que permiten entre 3 y 6 jugadores");
            Console.WriteLine("4. Calcular el promedio de duración de los juegos");
            Console.WriteLine("5. Mostrar juegos con duración menor a 30 minutos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void OrdenarBurbujaDuracion(ref Juego[] juegos)
        {
            for (int i = 0; i < juegos.Length - 1; i++)
            {
                for (int j = 0; j < juegos.Length - i - 1; j++)
                {
                    if (juegos[j].duracion > juegos[j + 1].duracion)
                    {
                        Juego aux = juegos[j];
                        juegos[j] = juegos[j + 1];
                        juegos[j + 1] = aux;
                    }
                }
            }
        }
        
        static int BusquedaBinariaDuracion(ref Juego[] juegos)
        {
            int inicio = 0;
            int final = juegos.Length - 1;
            int indice = -1;

            while (inicio <= final && indice == -1)
            {
                int medio = (inicio + final) / 2;

                if (juegos[medio].duracion <= 30)
                {
                    indice = medio;
                }
                else if (juegos[medio].duracion > 30)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }
            }

            return indice;
        }



        static void JuegosEntre3Y6Jugadores(ref Juego[] juegos)
        {
            Console.Write($"Los juegos que tiene entre 3 y 6 jugadores son:");

            for (int i = 0; i < juegos.Length; i++)
            {
                if (juegos[i].cantidad_minima >= 3 && juegos[i].cantidad_maxima <= 6)
                {
                    Console.WriteLine($"Nombre: {juegos[i].nombre}");
                }
            }
        }

        static void CargarJuegos(ref Juego[] juegos)
        {
            Console.WriteLine("Ingrese la informacion de cada juego");

            for (int i = 0; i < juegos.Length; i++)
            {
                Console.Write("Nombre: ");
                juegos[i].nombre = Console.ReadLine();

                Console.Write("Cantidad minima: ");
                juegos[i].cantidad_minima = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cantidad maxima: ");
                juegos[i].cantidad_maxima = Convert.ToInt32(Console.ReadLine());

                Console.Write("Duracion: ");
                juegos[i].duracion = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void MostrarJuegos(ref Juego[] juegos)
        {
            Console.WriteLine("Juegos disponibles");

            for (int i = 0; i < juegos.Length; i++)
            {
                Console.WriteLine($"Nombre: {juegos[i].nombre}");
                Console.WriteLine($"Cantidad minima: {juegos[i].cantidad_minima} jugadores");
                Console.WriteLine($"Cantidad maxima: {juegos[i].cantidad_maxima} jugadores");
                Console.WriteLine($"Duracion: {juegos[i].duracion} minutos");
            }
        }

        static void PromedioDuracion(ref Juego[] juegos)
        {
            int contador,
                suma_duraciones;

            double promedio;

            suma_duraciones = 0;
            contador = 0;

            for (int i = 0; i < juegos.Length; i++)
            {
                suma_duraciones += juegos[i].duracion;
                contador++;
            }

            promedio = (double)suma_duraciones / contador;

            Console.WriteLine($"La duracion promedio de los juegos fue de: {promedio:F2} minutos");
        }

        static void JuegosMenorA30(ref Juego[] juegos)
        {
            OrdenarBurbujaDuracion(ref juegos);

            int i = BusquedaBinariaDuracion(ref juegos);

            if (i == -1)
            {
                Console.WriteLine("No hay juegos con una duracion menor a 30 minutos");
            }
            
            while (i > 0 && juegos[i - 1].duracion <= 30)
            {
                i--;
            }

            Console.WriteLine("Los juegos con una duracion menor a 30 mintuos son:");

            while (i <= juegos.Length - 1 && juegos[i].duracion <= 30)
            {
                Console.WriteLine($"Nombre: {juegos[i].nombre}, Duracion: {juegos[i].duracion} minutos");
                i++;
            }
        }
        static void Main(string[] args)
        {
            Juego[] juegos;

            const int CANTIDAD_JUEGOS = 5;

            juegos = new Juego[CANTIDAD_JUEGOS];

            string opcion;

            do
            {
                Menu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CargarJuegos(ref juegos);
                        break;
                    case "2":
                        MostrarJuegos(ref juegos);
                        break;
                    case "3":
                        JuegosEntre3Y6Jugadores(ref juegos);
                        break;
                    case "4":
                        PromedioDuracion(ref juegos);
                        break;
                    case "5":
                        JuegosMenorA30(ref juegos);
                        break;
                }

            } while (opcion != "0");
        }
    }
}
