namespace sum_two_numbers
{
    internal class Program
    {
        public struct tipo_empleado
        {
            public int legajo;
            public string nombre;
            public string sector;
            public double salario;
        }

        static void Menu()
        {
            Console.WriteLine("--- Menú de Gestión de Empleados ---");
            Console.WriteLine("1. Cargar empleados");
            Console.WriteLine("2. Mostrar lista completa");
            Console.WriteLine("3. Mostrar empleado con mayor salario");
            Console.WriteLine("4. Buscar empleados por sector");
            Console.Write("Seleccione una opción: ");
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

        static void OrdenarBurbuja(ref tipo_empleado[] empleados)
        {
            for (int i = 0; i < empleados.Length - 1; i++)
            { 
                for (int j = 0; j < empleados.Length - i - 1; j++)
                {
                    if (empleados[j].salario > empleados[j + 1].salario)
                    {
                        tipo_empleado aux = empleados[j];
                        empleados[j] = empleados[j + 1];
                        empleados[j + 1] = aux;
                    }
                }
            }
        }

        static void OrdenarPorSector(ref tipo_empleado[] empleados)
        {
            for (int i = 0; i < empleados.Length - 1; i++)
            {
                for (int j = 0; j < empleados.Length - i - 1; j++)
                {
                    if (string.Compare(empleados[j].sector, empleados[j + 1].sector) > 0)
                    {
                        // Intercambiar
                        tipo_empleado aux = empleados[i];
                        empleados[i] = empleados[j];
                        empleados[j] = aux;
                    }
                }
            }
        }

        static void BuscarPorSector(ref tipo_empleado[] empleados, int cantidad, string sectorBuscado)
        {
            OrdenarPorSector(ref empleados);

            int inicio = 0;
            int fin = cantidad - 1;
            int indice = -1;

            // Búsqueda binaria
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                int comparacion = string.Compare(empleados[medio].sector, sectorBuscado);

                if (comparacion == 0)
                {
                    indice = medio;
                    break;
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (indice == -1)
            {
                Console.WriteLine("No se encontraron empleados en ese sector.");
                return;
            }

            // Recorrer hacia atrás y adelante desde 'indice'
            int i = indice;

            // Ir hacia atrás
            while (i > 0 && string.Compare(empleados[i - 1].sector, sectorBuscado) == 0)
            {
                i--;
            }

            // Mostrar todos los que coincidan hacia adelante
            while (i < cantidad && string.Compare(empleados[i].sector, sectorBuscado) == 0)
            {
                Console.WriteLine($"Legajo: {empleados[i].legajo}, Nombre: {empleados[i].nombre}, Salario: ${empleados[i].salario}");
                i++;
            }
        }

        static void CargarEmpleados(ref tipo_empleado[] empleados, int cantidad)
        {
            tipo_empleado nuevo_empleado = new tipo_empleado();

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese los datos del empleado {i + 1}");

                Console.Write("Nombre: ");
                nuevo_empleado.nombre = Console.ReadLine();

                nuevo_empleado.legajo = ObtenerNumeroPositivo("Legajo: ");

                Console.Write("Salario: ");
                nuevo_empleado.salario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sector: ");
                nuevo_empleado.sector = Console.ReadLine();

                empleados[i] = nuevo_empleado;
            }
        }

        static void MostrarListaDeEmpleados(ref tipo_empleado[] empleados)
        {
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine($"Datos del empleado {i + 1}");

                Console.WriteLine($"Nombre: {empleados[i].nombre}");
                Console.WriteLine($"Legajo: {empleados[i].legajo}");
                Console.WriteLine($"Salario: {empleados[i].salario}");
                Console.WriteLine($"Sector: {empleados[i].sector}");
            }
        }

        static void EmpleadoMayorSalario(ref tipo_empleado[] empleados)
        {
            OrdenarBurbuja(ref empleados);

            Console.WriteLine($"El empleado con mayor salario es");

            Console.WriteLine($"Nombre: {empleados[empleados.Length - 1].nombre}");
            Console.WriteLine($"Legajo: {empleados[empleados.Length - 1].legajo}");
            Console.WriteLine($"Salario: {empleados[empleados.Length - 1].salario}");
            Console.WriteLine($"Sector: {empleados[empleados.Length - 1].sector}");
        }
        static void Main(string[] args)
        {
            tipo_empleado[] empleados;

            empleados = new tipo_empleado[0];

            int cantidad_empleados;

            string opcion,
                   sector_buscado;

            do
            {
                Menu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        cantidad_empleados = ObtenerNumeroPositivo("Cuantos empleados desea cargar?");
                        empleados = new tipo_empleado[cantidad_empleados];

                        CargarEmpleados(ref empleados, cantidad_empleados);
                        break;
                    case "2":
                        MostrarListaDeEmpleados(ref empleados);
                        break;
                    case "3":
                        EmpleadoMayorSalario(ref empleados);
                        break;
                    case "4":
                        Console.WriteLine("Que sector quiere buscar");
                        sector_buscado = Console.ReadLine();
                        BuscarPorSector(ref empleados, empleados.Length, sector_buscado);
                        break;
                }
            } while (opcion != "0");
        }
    }
}
