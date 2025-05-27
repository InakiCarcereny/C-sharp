namespace sum_two_numbers
{
    internal class Program
    {
        static string[] nombres = new string[5];
        static int[,] ventas = new int[5, 12];

        static void Menu()
        {
            Console.WriteLine("1 - Cargar los valores");
            Console.WriteLine("2 - Mostrar las ventas");
            Console.WriteLine("3 - Mostrar la sucursal con mas ventas");
            Console.WriteLine("4 - Mostrar el mes de mayores ventas en la sucursal que más vendió en el año");
            Console.WriteLine("5 - Elegir una sucursal y mostrar las ventas mensuales que tuvo");
            Console.WriteLine("6 - Mostrar el promedio mensual y anual de ventas de la empresa");
            Console.WriteLine("0 - Salir");
        }

        static void CargarValores()
        {
            bool exito;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la sucursal {i + 1}");
                nombres[i] = Console.ReadLine();
                
                for (int j = 0; j < 12; j++)
                {
                    do
                    {
                        Console.WriteLine($"Ingrese la venta del mes {j + 1} de la sucursal {i + 1}");
                        exito = int.TryParse(Console.ReadLine(), out ventas[i, j]);
                    } while (!exito);
                }
            }
        }

        static void MostrarValores()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Sucursal {nombres[i]}");

                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine($"En el mes {j + 1} se vendieron {ventas[i, j]}");
                }
            }
        }

        static string SucursalConMasVentas()
        {
            int[] ventas_por_sucursal = new int[nombres.Length];
            int mayor_ventas_sucursal = 0;
            string mayor_ventas = "";

            for (int i = 0; i < nombres.Length; i++)
            {
                int total_ventas = 0;

                for (int j = 0; j < 12; j++)
                {
                    total_ventas += ventas[i, j];
                }

                ventas_por_sucursal[i] = total_ventas;

                Console.WriteLine($"El total de ventas de la sucursal {nombres[i]} fue {total_ventas}");
            }

            mayor_ventas_sucursal = ventas_por_sucursal[0];
            mayor_ventas = nombres[0];

            for (int i = 1; i < ventas_por_sucursal.Length; i++)
            {
                if (ventas_por_sucursal[i] > mayor_ventas_sucursal)
                {
                    mayor_ventas_sucursal = ventas_por_sucursal[i];
                    mayor_ventas = nombres[i];
                }
            }

            return mayor_ventas;
        }

        static void MesMayorVentasSucursalMasVentas()
        {
            
        }

        static void MostrarVentasMensualesSucursal()
        {
            int sucursal;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{i + 1} - Sucursal: {nombres[i]}");
            }

            Console.WriteLine("Seleccione el numero de la sucursal que quiere ver sus ventas mensuales");
            sucursal = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Ventas mes {i + 1}: {ventas[sucursal, i]}");
            }
        }

        static void Main(string[] args)
        {
            int opcion;

            string mayor_ventas;

            bool exito;

            do
            {
                Menu();

                Console.WriteLine("Ingrese una opcion entre el 0 y el 6 inclusive");
                exito = int.TryParse(Console.ReadLine(), out opcion);

                switch(opcion)
                {
                    case 0: Console.WriteLine("Saliendo...");
                        break;
                    case 1: CargarValores();
                        break;
                    case 2: MostrarValores();
                        break;
                    case 3: mayor_ventas = SucursalConMasVentas();
                        Console.WriteLine($"La sucursal con mayor ventas fue {mayor_ventas}.");
                        break;
                    case 4: MesMayorVentasSucursalMasVentas();
                        break;
                    case 5: MostrarVentasMensualesSucursal();
                        break;
                }
            } while (opcion != 0);
        }
    }
}
