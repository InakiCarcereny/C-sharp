namespace sum_two_numbers
{
    internal class Program
    {
        public struct tipo_Libro
        {
            public int codigo;
            public string ISBN;
            public string autor;
            public string titulo;
            public bool esta_prestado;
        }

        static void Menu()
        {
            Console.WriteLine("Bienvenido a la biblioteca");
            Console.WriteLine("1 - Registrar un libro");
            Console.WriteLine("2 - Buscar libro por ISBN");
            Console.WriteLine("3 - Cambiar estado de prestamo");
            Console.WriteLine("4 - Mostrar todos los libros");
            Console.WriteLine("5 - Contar libros prestados");
            Console.WriteLine("0 - Salir");
            Console.Write("Opcion elegida");
        }

        static int ObtenerNumeroPositivo(string mensaje)
        {
            int numero;

            bool exito;

            do
            {
                Console.WriteLine(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);
            } while (!exito || numero < 0);

            return numero;
        }

        static void CargarLibro(ref tipo_Libro[] libros, ref int indice_ultimo_libro)
        {
            tipo_Libro libro_nuevo = new tipo_Libro();

            if (indice_ultimo_libro < libros.Length - 1)
            {
                Console.WriteLine("Ingresar los datos del libro");
                libro_nuevo.codigo = ObtenerNumeroPositivo("Ingrese el codigo del libro");

                Console.WriteLine("Ingrese el ISBN");
                libro_nuevo.ISBN = Console.ReadLine();
                
                Console.WriteLine("Ingrese el titulo del libro");
                libro_nuevo.titulo = Console.ReadLine();
                
                Console.WriteLine("Ingrese el autor");
                libro_nuevo.autor = Console.ReadLine();
                
                libro_nuevo.esta_prestado = false;

                if (ExisteISBN(ref libros, indice_ultimo_libro, libro_nuevo.ISBN))
                {
                    Console.WriteLine("Ya existe un libro con ese ISBN");
                }
                else
                {
                    indice_ultimo_libro++;
                    libros[indice_ultimo_libro] = libro_nuevo;
                    OrdenarPorISBN(ref libros, indice_ultimo_libro);
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar para libros");
                Console.WriteLine("Redimensionando...");
                RedimensionarArreglo(ref libros);
            }
        }

        static void RedimensionarArreglo(ref tipo_Libro[] libros)
        {
            tipo_Libro[] aux = new tipo_Libro[libros.Length + 100];

            for (int i = 0; i < libros.Length; i++)
            {
                aux[i] = libros[i];
            }

            libros = aux;
        }

        static void OrdenarPorISBN(ref tipo_Libro[] libros, int indice_ultimo_libro)
        {
            for (int i = 0; i < indice_ultimo_libro; i++)
            {
                for (int j = 0; j < indice_ultimo_libro; j++)
                {
                    if (string.Compare(libros[j].ISBN, libros[j + 1].ISBN) > 0)
                    {
                        tipo_Libro aux = libros[j];
                        libros[j] = libros[j + 1];
                        libros[j + 1] = aux;
                    }
                }
            }
        }

        static bool ExisteISBN(ref tipo_Libro[] libros, int indice_ultimo_libro, string ISBN_buscado)
        {
            if (BusquedaBinariaISBN(ref libros, indice_ultimo_libro, ISBN_buscado) == -1)
            {
                return false;
            }

            return true;
        }

        static int BusquedaBinariaISBN(ref tipo_Libro[] libros, int indice_ultimo_libro, string ISBN_buscado)
        {
            int inicio = 0;
            int final = indice_ultimo_libro;
            int indice = -1;

            while(inicio <= final && indice == -1)
            {
                int medio = (inicio + final) / 2;

                if (string.Compare(libros[medio].ISBN, ISBN_buscado) == 0)
                {
                    indice = medio;
                }
                else if (string.Compare(libros[medio].ISBN, ISBN_buscado) < 0)
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

        static void MostrarLibros(ref tipo_Libro[] libros, int indice_ultimo_libro)
        {
            if (libros.Length < 0)
            {
                Console.WriteLine("Todavia no hay libros");
            }
            else
            {
                for (int i = 0; i < indice_ultimo_libro; i++)
                {
                    Console.WriteLine($"Libro en la posicion {i}");
                    Console.WriteLine($"Titulo: {libros[i].titulo}");
                    Console.WriteLine($"Codigo: {libros[i].codigo}");
                    Console.WriteLine($"ISBN: {libros[i].ISBN}");
                    Console.WriteLine($"Autor: {libros[i].autor}");

                    if (libros[i].esta_prestado)
                    {
                        Console.WriteLine("Esta prestado");
                    }
                    else
                    {
                        Console.WriteLine("NO esta prestado");
                    }
                }
            }
        }

        static void MostrarInfoPorISBN(ref tipo_Libro[] libros, int indice_ultima_posicion)
        {
            Console.WriteLine("Ingrese el ISBN a buscar: ");
            string ISBN_buscado = Console.ReadLine();

            int indice = BusquedaBinariaISBN(ref libros, indice_ultima_posicion, ISBN_buscado);

            if (indice != -1)
            {
                Console.WriteLine("Datos del libro");
                Console.WriteLine($"Titulo: {libros[indice].titulo}");
                Console.WriteLine($"Codigo: {libros[indice].codigo}");
                Console.WriteLine($"ISBN: {libros[indice].ISBN}");
                Console.WriteLine($"Autor: {libros[indice].autor}");
                if (libros[indice].esta_prestado)
                {
                    Console.WriteLine("Esta prestado");
                }
                else
                {
                    Console.WriteLine("NO esta prestado");
                }
            }
            else
            {
                Console.WriteLine("El libro NO existe");
            }
        }

        static void OrdenarPorCodigo(ref tipo_Libro[] libros, int indice_ultimo_libro)
        {
            for (int i = 0; i < indice_ultimo_libro; i++)
            {
                for (int j = 0; j < indice_ultimo_libro; j++)
                {
                    if (libros[j].codigo > libros[j + 1].codigo)
                    {
                        tipo_Libro aux = libros[j];
                        libros[j] = libros[j + 1];
                        libros[j + 1] = aux;
                    }
                }
            }
        }

        static int BusquedaBinariaCodigo(ref tipo_Libro[] libros, int indice_ultimo_libro, int codigo_buscado)
        {
            int inicio = 0;
            int final = indice_ultimo_libro;
            int indice = -1;

            while (inicio <= final && indice == -1)
            {
                int medio = (inicio + final) / 2;

                if (libros[medio].codigo == codigo_buscado)
                {
                    indice = medio;
                }
                else if (libros[medio].codigo < codigo_buscado)
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

        static void CambiarEstadoLibro(ref tipo_Libro[] libros, int indice_ultima_posicion)
        {
            int codigo_buscado = ObtenerNumeroPositivo("Ingrese el codigo del libro que quiere modificar");
            OrdenarPorCodigo(ref libros, indice_ultima_posicion);

            int indice = BusquedaBinariaCodigo(ref libros, indice_ultima_posicion, codigo_buscado);

            if (indice != -1)
            {
                libros[indice].esta_prestado = !libros[indice].esta_prestado;

                if (libros[indice].esta_prestado)
                {
                    Console.WriteLine("El libro esta prestado");
                }
                else
                {
                    Console.WriteLine("El libro fue devuelto");
                }
            }
            else
            {
                Console.WriteLine("No se encontro el libro");
            }

            OrdenarPorISBN(ref libros, indice_ultima_posicion);
        }

        static void ContarLibrosPrestados(ref tipo_Libro[] libros, int indice_ultimo_libro)
        {
            int cantidad;

            cantidad = 0;

            for (int i = 0; i <= indice_ultimo_libro; i++)
            {
                if (libros[i].esta_prestado)
                {
                    cantidad++;
                }
            }

            Console.WriteLine($"Hay {cantidad} libros prestados");
        }

        static void Main(string[] args)
        {
            tipo_Libro[] libros;

            int indice_ultimo_libro = -1;

            libros = new tipo_Libro[200];

            string opcion;

            do
            {
                Menu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CargarLibro(ref libros, ref indice_ultimo_libro);
                        break;
                    case "2":
                        MostrarInfoPorISBN(ref libros, indice_ultimo_libro);
                        break;
                    case "3":
                        CambiarEstadoLibro(ref libros, indice_ultimo_libro);
                        break;
                    case "4":
                        MostrarLibros(ref libros, indice_ultimo_libro);
                        break;
                    case "5":
                        ContarLibrosPrestados(ref libros, indice_ultimo_libro);
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (opcion != "0");
        }
    }
}
