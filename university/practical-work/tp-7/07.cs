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

            if (indice != -1)
            {
                return true;
            }

            return false;
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

            codigo_buscado = NumeroPositivo("Ingrese el codigo del producto a buscar", 999, 9999);

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
        static void Main(string[] args)
        {
            string opcion;

            Producto[] productos;

            int indice = -1;

            const int CANTIDAD_PRODUCTOS = 100;

            productos = new Producto[CANTIDAD_PRODUCTOS];

            do
            {
                Menu();
                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1": CargarProducto(ref productos, ref indice);
                        break;
                }
            } while (opcion != "0");
        }
    }
}
