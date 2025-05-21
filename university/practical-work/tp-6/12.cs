namespace sum_two_numbers
{
    internal class Program
    {
        static int[] ventas = new int[12];

        static void Menu()
        {
            Console.WriteLine("1 - Cargar los valores");
            Console.WriteLine("2 - Mostrar las ventas");
            Console.WriteLine("3 - Mostrar total anual vendido");
            Console.WriteLine("4 - Mostrar promedio mensual de ventas");
            Console.WriteLine("5 - Mostrar los meses que las ventas superaron al promedio anual");
            Console.WriteLine("6 - Mostrar los mese que las ventas estuvieron por debajo del promedio anual");
            Console.WriteLine("0 - Salir");
        }

        static void CargarValores()
        {
            bool exito;

            for (int i = 0; i < ventas.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese las ventas del mes {i + 1}");
                    exito = int.TryParse(Console.ReadLine(), out ventas[i]);
                } while (!exito);
            }
        }

        static void MostrarValores()
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"El mes {i + 1} se vendieron {ventas[i]}");
            }
        }

        static int TotalAnual()
        {
            int total_anual_vendido;

            total_anual_vendido = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                total_anual_vendido += ventas[i];
            }

            return total_anual_vendido;
        }

        static double PromedioMensual()
        {
            int suma;
            double promedio;

            suma = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                suma += ventas[i];
            }

            promedio = suma / ventas.Length;

            return promedio;
        }

        static int[] MesesSuperiorPromedioAnual()
        {
            double obtener_promedio;
            int[] meses_mayor_promedio_anual;
            int contador;

            meses_mayor_promedio_anual = new int[12];
            obtener_promedio = PromedioMensual();
            contador = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] > obtener_promedio)
                {
                    meses_mayor_promedio_anual[contador] = i + 1;
                    contador++;
                }
            }

            int[] resultado = new int[contador];

            for (int i = 0; i < contador; i++)
            {
                resultado[i] = meses_mayor_promedio_anual[i];
            }

            return resultado;
        }

        static int[] MesesMenoresPromedioAnual()
        {
            double obtener_promedio;
            int[] meses_menor_promedio_anual;
            int contador;

            meses_menor_promedio_anual = new int[12];
            obtener_promedio = PromedioMensual();
            contador = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] < obtener_promedio)
                {
                    meses_menor_promedio_anual[contador] = i + 1;
                    contador++;
                }
            }

            int[] resultado = new int[contador];

            for (int i = 0; i < contador; i++)
            {
                resultado[i] = meses_menor_promedio_anual[i];
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            int[] meses_menores_promedio_anual,
                  meses_mayores_promedio_anual;
            int opcion,
                total_anual;
            double promedio_mensual;
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
                    case 3: 
                        total_anual = TotalAnual();
                        Console.WriteLine($"El total anual es {total_anual}");
                        break;
                    case 4: 
                        promedio_mensual = PromedioMensual();
                        Console.WriteLine($"El promedio mensual es {promedio_mensual}");
                        break;
                    case 5: 
                        meses_mayores_promedio_anual = MesesSuperiorPromedioAnual();
                        for (int i = 0; i < meses_mayores_promedio_anual.Length; i++)
                        {
                            Console.WriteLine($"mes {meses_mayores_promedio_anual[i]}");
                        }
                        break;
                    case 6: 
                        meses_menores_promedio_anual = MesesMenoresPromedioAnual();
                        for (int i = 0; i < meses_menores_promedio_anual.Length; i++)
                        {
                            Console.WriteLine($"mes {meses_menores_promedio_anual[i]}");
                        }
                        break;
                }
            } while (opcion != 0);
        }
    }
}
