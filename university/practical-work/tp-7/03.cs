namespace sum_two_numbers
{
    internal class Program
    {
        public struct tipo_libro
        {
            public string titulo;
            public string autor;
            public int anio;
            public int stock;
        }

        static void Menu()
        {
            Console.WriteLine("Bienvenido al sistema");
            Console.WriteLine("1 - Cargar libro");
            Console.WriteLine("2 - Buscar libro por autor");
            Console.WriteLine("3 - Buscar libro por anio");
            Console.WriteLine("4 - Mostrar libros");
            Console.Write("Seleccione su opcion: ");
        }

        static int NumeroPositivo(string mensaje, int tope_rango)
        {
            int numero;

            bool exito;

            do
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);
            } while (!exito || numero < 0 || numero > tope_rango);

            return numero;
        }

        static void OrdenarBurbujaAutor(ref tipo_libro[] libros, int indice_ultimo_libro)
        {
            for (int i = 0; i < indice_ultimo_libro; i++)
            {
                for (int j = 0; j < indice_ultimo_libro; j++)
                {
                    if (string.Compare(libros[j].autor, libros[j + 1].autor) > 0)
                    {
                        tipo_libro aux = libros[j];
                        libros[j] = libros[j + 1];
                        libros[j + 1] = aux;
                    }
                }
            }
        }

        static int BusquedaBinariaAutor(ref tipo_libro[] libros, int indice_ultimo_libro, string autor_buscado)
        {
            int inicio = 0;
            int final = indice_ultimo_libro;
            int indice = -1;

            while (inicio <= final && indice == -1)        
            {
                int medio = (inicio + final) / 2;

                if (libros[medio].autor == autor_buscado)
                {
                    indice = medio;
                }
                else if (libros[medio].autor != autor_buscado)
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


        static void CargarLibro(ref tipo_libro[] libros, ref int indice_ultimo_libro)
        {
            tipo_libro libro_nuevo = new tipo_libro();

            if (indice_ultimo_libro < libros.Length - 1)
            {
                Console.WriteLine("Ingrese los datos del libro");

                Console.Write("Ingrese el titulo del libro: ");
                libro_nuevo.titulo = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Igrese el autor: ");
                libro_nuevo.autor = Console.ReadLine();
                Console.WriteLine();

                libro_nuevo.anio = NumeroPositivo("Ingrese el anio de publicacion: ", 2025);
                Console.WriteLine();

                libro_nuevo.stock = NumeroPositivo("Ingrese el stock: ", 50);
                Console.WriteLine();

                indice_ultimo_libro++;
                libros[indice_ultimo_libro] = libro_nuevo;
            }
            else
            {
                Console.WriteLine("No hay mas espacio");
            }
        }

        static void Main(string[] args)
        {
            tipo_libro[] libros;

            int indice_ultimo_libro;

            string opcion;

            const int CANTIDAD_LIBROS = 10;

            libros = new tipo_libro[CANTIDAD_LIBROS];

            indice_ultimo_libro = -1;

            do
            {
                Menu();
                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1": CargarLibro(ref libros, ref indice_ultimo_libro);
                        break;
                    case "2": BuscarLibroPorAutor();
                        break;
                    case "3": BuscarLibroPorAnio();
                        break;
                    case "4": MostrarLibros();
                        break;
                }
            } while (opcion != "0");
        }
    }
}
