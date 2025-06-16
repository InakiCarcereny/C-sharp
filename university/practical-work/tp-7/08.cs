namespace sum_two_numbers
{
    internal class Program
    {
        public struct Vehiculo
        {
            public string patente;
            public string marca;
            public string modelo;
            public int anio;
            public int kilometros;
        }

        static void Menu()
        {
            Console.WriteLine("--- MENÚ DE CONCESIONARIA ---");
            Console.WriteLine("1. Cargar vehículos");
            Console.WriteLine("2. Mostrar todos los vehículos");
            Console.WriteLine("3. Mostrar vehículo con más kilómetros recorridos");
            Console.WriteLine("4. Contar vehículos del año 2020 en adelante");
            Console.WriteLine("5. Promedio de kilometraje de vehículos con más de 5 años");
            Console.Write("Seleccione una opción: ");
        }

        static void OrdenarBurbuja(ref Vehiculo[] vehiculos)
        {
            for (int i = 0; i < vehiculos.Length - 1; i++)
            {
                for (int j = 0; j < vehiculos.Length - i - 1; j++)
                {
                    if (vehiculos[j].kilometros > vehiculos[j + 1].kilometros)
                    {
                        Vehiculo aux = vehiculos[j];
                        vehiculos[j] = vehiculos[j + 1];
                        vehiculos[j + 1] = aux;
                    }
                }
            }
        }

        static void OrdenarBurbujaAnio(ref Vehiculo[] vehiculos)
        {
            for (int i = 0; i < vehiculos.Length - 1; i++)
            {
                for (int j = 0; j < vehiculos.Length - i - 1; j++)
                {
                    if (vehiculos[j].anio > vehiculos[j + 1].anio)
                    {
                        Vehiculo aux = vehiculos[j];
                        vehiculos[j] = vehiculos[j + 1];
                        vehiculos[j + 1] = aux;
                    }
                }
            }
        }

        static int BusquedaBinariaAnios(ref Vehiculo[] vehiculos)
        {
            int inicio = 0;
            int fin = vehiculos.Length - 1;
            int indice = -1;

            while (inicio <= fin && indice == -1)
            {
                int medio = (inicio + fin) / 2;

                if (vehiculos[medio].anio >= 2020)
                {
                    indice = medio;
                }
                else if (vehiculos[medio].anio < 2020)
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

        static void VehiculosMayor2020(ref Vehiculo[] vehiculos)
        {
            OrdenarBurbujaAnio(ref vehiculos);

            int i = BusquedaBinariaAnios(ref vehiculos);
            int contador;

            contador = 0;

            while (i > 0 && vehiculos[i - 1].anio >= 2020)
            {
                i--;
            }

            while (i <= vehiculos.Length - 1 && vehiculos[i].anio >= 2020)
            {
                contador++;
                i++;
            }

            Console.WriteLine($"La cantidad de vehiculos mayores al anio 2020 son {contador}");
        }

        static void CargarVehiculos(ref Vehiculo[] vehiculos)
        {
            for (int i = 0; i < vehiculos.Length; i++)
            {
                Console.WriteLine($"Ingrese los datos del vehiculo {i + 1}");

                Console.Write("Patente: ");
                vehiculos[i].patente = Console.ReadLine();

                Console.Write("Marca: ");
                vehiculos[i].marca = Console.ReadLine();

                Console.Write("Modelo: ");
                vehiculos[i].modelo = Console.ReadLine();

                Console.Write("Anio: ");
                vehiculos[i].anio = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kilometros: ");
                vehiculos[i].kilometros = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void MostrarVehiculos(ref Vehiculo[] vehiculos)
        {
            Console.WriteLine("Listado de vehiculos");

            for (int i = 0; i < vehiculos.Length; i++)
            {
                Console.Write($"Patente: {vehiculos[i].patente}");

                Console.Write($"Marca: {vehiculos[i].marca}");

                Console.Write($"Modelo: {vehiculos[i].modelo}");

                Console.Write($"Anio: {vehiculos[i].anio}");

                Console.Write($"Kilometros: {vehiculos[i].kilometros}");
            }
        }

        static void VehiculoMayorKilometraje(ref Vehiculo[] vehiculos)
        {
            OrdenarBurbuja(ref vehiculos);

            Console.WriteLine("Informacion vehiculo con mas kilometros");
            Console.WriteLine($"Patente: {vehiculos[vehiculos.Length - 1].patente}");
            Console.WriteLine($"Marca: {vehiculos[vehiculos.Length - 1].marca}");
            Console.WriteLine($"Modelo: {vehiculos[vehiculos.Length - 1].modelo}");
            Console.WriteLine($"Anio: {vehiculos[vehiculos.Length - 1].anio}");
            Console.WriteLine($"Kilometros: {vehiculos[vehiculos.Length - 1].kilometros}");
        }

        static void PromedioKilometraje(ref Vehiculo[] vehiculos)
        {
            int anio_actual,
                contador,
                suma_kilometros;

            double promedio;

            anio_actual = 2025;
            contador = 0;
            suma_kilometros = 0;

            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (anio_actual - vehiculos[i].anio > 5)
                {
                    suma_kilometros += vehiculos[i].kilometros;
                    contador++;
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay vehiculos con 5 anios de diferencia");
            }
            else
            {
                promedio = suma_kilometros / contador;
                Console.WriteLine($"Promedio de kilometraje de vehículos con más de 5 años: {promedio:F2}");
            }
        }

        static void Main(string[] args)
        {
            Vehiculo[] vehiculos;

            const int CANTIDAD_VEHICULOS = 10;

            vehiculos = new Vehiculo[CANTIDAD_VEHICULOS];

            string opcion;

            do
            {
                Menu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CargarVehiculos(ref vehiculos);
                        break;
                    case "2":
                        MostrarVehiculos(ref vehiculos);
                        break;
                    case "3":
                        VehiculoMayorKilometraje(ref vehiculos);
                        break;
                    case "4":
                        VehiculosMayor2020(ref vehiculos);
                        break;
                    case "5":
                        PromedioKilometraje(ref vehiculos);
                        break;
                }

            } while (opcion != "0");
        }
    }
}
