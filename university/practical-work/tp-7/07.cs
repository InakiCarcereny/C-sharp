namespace sum_two_numbers
{
    internal class Program
    {
        public struct Producto
        {
            public int codigo;
            public string nombre;
            public int stock;
            public int stock_minimo;
        }

        static void Menu()
        {
            Console.WriteLine("--- Menú de Gestión de Almacén ---");
            Console.WriteLine("1. Registrar nuevo producto");
            Console.WriteLine("2. Buscar producto por código");
            Console.WriteLine("3. Editar producto");
            Console.WriteLine("4. Borrar producto");
            Console.WriteLine("5. Mostrar todos los productos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static int NumeroPositivo(string mensaje, int minimo, int maximo)
        {
            int numero;

            bool exito;

            do
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);
            } while (!exito || numero < minimo || numero > maximo);

            return numero;
        }

        static void OrdenarPorCodigo(ref Producto[] productos, int indice_ultimo_producto)
        {
            for (int i = 0; i < indice_ultimo_producto; i++)
            {
                for (int j = 0; j < indice_ultimo_producto; j++)
                {
                    if (productos[j].codigo > productos[j + 1].codigo)
                    {
                        Producto aux = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = aux;
                    }
                }
            }
        }

        static int BusquedaBinariaCodigo(ref Producto[] productos, int indice_ultimo_producto, int codigo_buscado)
        {
            OrdenarPorCodigo(ref productos, indice_ultimo_producto);

            int inicio = 0;
            int fin = indice_ultimo_producto;
            int indice = -1;

            while (inicio <= fin && indice == -1)
            {
                int medio = (inicio + fin) / 2;

                if (productos[medio].codigo == codigo_buscado)
                {
                    indice = medio;
                }
                else if (productos[medio].codigo < codigo_buscado)
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

        static bool ExisteProducto(ref Producto[] productos, int indice_ultimo_producto, int codigo_buscado)
        {
            int indice;

            indice = BusquedaBinariaCodigo(ref productos, indice_ultimo_producto, codigo_buscado);

            if (indice == -1)
            {
                return false;
            }

            return true;
        }

        static void CargarProducto(ref Producto[] productos, ref int indice_ultimo_producto)
        {
            Producto nuevo_producto = new Producto();

            if (indice_ultimo_producto < productos.Length - 1)
            {
                Console.WriteLine("Ingrese los datos del producto");

                Console.Write("Nombre: ");
                nuevo_producto.nombre = Console.ReadLine();

                nuevo_producto.codigo = NumeroPositivo("Codigo: ", 999, 9999);

                nuevo_producto.stock = NumeroPositivo("Stock: ", 0, 100);

                nuevo_producto.stock_minimo = NumeroPositivo("Stock minimio: ", 0, 100);

                if (ExisteProducto(ref productos, indice_ultimo_producto, nuevo_producto.codigo))
                {
                    Console.WriteLine("El producto YA existe con ese codigo");
                }
                else
                {
                    indice_ultimo_producto++;
                    productos[indice_ultimo_producto] = nuevo_producto;
                }
            }
            else
            {
                Console.WriteLine("No se pueden agregar mas productos");
            }
        }

        static void MostrarInfoProductoBuscado(ref Producto[] productos, int indice_ultimo_producto)
        {
            int indice,
                codigo_buscado;

            codigo_buscado = NumeroPositivo("Ingrese el codigo del producto a buscar: ", 999, 9999);

            indice = BusquedaBinariaCodigo(ref productos, indice_ultimo_producto, codigo_buscado);

            if (indice != -1)
            {
                Console.WriteLine("Datos del producto");
                Console.WriteLine($"Nombre: {productos[indice].nombre}");
                Console.WriteLine($"Codigo: {productos[indice].codigo}");
                Console.WriteLine($"Stock: {productos[indice].stock}");
                Console.WriteLine($"Stock_minimo: {productos[indice].stock_minimo}");
            }
            else
            {
                Console.WriteLine("El producto NO existe");
            }
        }

        static void EditarProdcuto(ref Producto[] productos, int indice_ultimo_producto)
        {
            int indice,
                codigo_buscado;

            codigo_buscado = NumeroPositivo("Ingrese el codigo del producto que quiere editar: ", 999, 9999);

            indice = BusquedaBinariaCodigo(ref productos, indice_ultimo_producto, codigo_buscado);

            if (indice != -1)
            {
                Console.WriteLine("Editar producto");

                Console.Write($"Nombre: ");
                productos[indice].nombre = Console.ReadLine();

                productos[indice].codigo = NumeroPositivo("Codigo: ", 999, 9999);

                productos[indice].stock = NumeroPositivo("Stock: ", 0, 100);

                productos[indice].stock_minimo = NumeroPositivo("Stock minimo: ", 0, 100);
            }
            else
            {
                Console.WriteLine("No hay ningun producto con ese codigo");
            }
        }

        static void BorrarProducto(ref Producto[] productos, ref int indice_ultimo_producto)
        {
            int codigo_buscado;

            codigo_buscado = NumeroPositivo("Ingrese el codigo del producto a buscar", 999, 9999);

            int indice = BusquedaBinariaCodigo(ref productos, indice_ultimo_producto, codigo_buscado);

            if (indice == -1)
            {
                Console.WriteLine("Producto no encontrado.");
                return;
            }

            for (int i = indice; i < indice_ultimo_producto; i++)
                productos[i] = productos[i + 1];

            indice_ultimo_producto--;

            Console.WriteLine("Producto eliminado.");
        }

        static void MostrarProductos(ref Producto[] productos, int indice_ultimo_producto)
        {
            for (int i = 0; i <= indice_ultimo_producto; i++)
            {
                Console.WriteLine("Informacion del producto");
                Console.WriteLine($"Nombre: {productos[i].nombre}");
                Console.WriteLine($"Codigo: {productos[i].codigo}");
                Console.WriteLine($"Stock: {productos[i].stock}");
                Console.WriteLine($"Stock_minimo: {productos[i].stock_minimo}");
            }
        }


        static void Main(string[] args)
        {
            string opcion;

            Producto[] productos;

            int indice = -1;

            const int CANTIDAD_PRODUCTOS = 2;

            productos = new Producto[CANTIDAD_PRODUCTOS];

            do
            {
                Menu();
                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1": CargarProducto(ref productos, ref indice);
                        break;
                    case "2": MostrarInfoProductoBuscado(ref productos, indice);
                        break;
                    case "3": EditarProdcuto(ref productos, indice);
                        break;
                    case "4": BorrarProducto(ref productos, ref indice);
                        break;
                    case "5": MostrarProductos(ref productos, indice);
                        break;
                }
            } while (opcion != "0");
        }
    }
}
