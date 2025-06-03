namespace Clase_3_6_ordenamiento
{
    internal class Program
    {
        static void MostrarMenu()
        {
            Console.WriteLine("Seleccíone una opcion:");
            Console.WriteLine(" 1 - Cargar calificaciones de los clientes");
            Console.WriteLine(" 2 - Ver la menor calificacion");
            Console.WriteLine(" 3 - Ver la mayor calificacion");
            Console.WriteLine(" 4 - ver si hubo repetidos");
            Console.WriteLine(" 5 - Ver listado");
            Console.WriteLine(" 6 - Ordenar listado calificaciones crecientes");
            Console.WriteLine(" 7 -  Ordenar listado calificacinoes decrecientes.");
            Console.WriteLine(" 0 - Salir");
        }

        static void Cargar(int[] calificaciones, string[] nombres)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write($"Ingrese el nombre del cliente {i + 1}: ");
                nombres[i] = Console.ReadLine();
                calificaciones[i] = PedirCalificacion(i + 1);
            }
        }

        static int PedirCalificacion(int numeroCliente)
        {
            Console.Write($"Ingrese la calificacion (1-10) del cliente {numeroCliente}: ");

            int calificacion;
            
            while (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 1 || calificacion > 10)
            {
                Console.Write("El valor ingresado es inválido. Ingrese la clificacion (1-10): ");
            }
            return calificacion;
        }

        static void MostrarListado(int[] calificaciones, string[] nombres)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"{nombres[i]}  -  {calificaciones[i]}");
            }
        }

        static void OrdenarBurbuja(int[] aCalificaciones, string[] aNombres, bool creciente)
        {
            // para cada elemento del arreglo,
            // lo voy comparando con el adyacente
            // si estan al reves los intercambio
            for (int i = 0; i < aCalificaciones.Length - 1; i++)
            {
                for (int j = 0; j < aCalificaciones.Length - 1; j++)
                {
                    //si quero orden creciente
                    // entonces reviso si a[j] > a[j+1] e intercambio
                    if (creciente)
                    {
                        if (aCalificaciones[j] > aCalificaciones[j + 1])
                        {
                            //hago intercambio
                            int auxCalif = aCalificaciones[j];
                            aCalificaciones[j] = aCalificaciones[j + 1];
                            aCalificaciones[j + 1] = auxCalif;

                            //acomodo el nombre
                            string auxNombre = aNombres[j];
                            aNombres[j] = aNombres[j + 1];
                            aNombres[j + 1] = auxNombre;
                        }
                    }
                    else if (aCalificaciones[j] < aCalificaciones[j + 1])
                    {
                        //hago intercambio
                        int auxCalif = aCalificaciones[j];
                        aCalificaciones[j] = aCalificaciones[j + 1];
                        aCalificaciones[j + 1] = auxCalif;

                        //acomodo el nombre
                        string auxNombre = aNombres[j];
                        aNombres[j] = aNombres[j + 1];
                        aNombres[j + 1] = auxNombre;
                    }
                }
            }
        }

        static void MostrarMenorPuntaje(int[] calif, string[] nombres)
        {
            OrdenarBurbuja(calif, nombres, true);
            
            Console.WriteLine($"El menor puntaje es: {calif[0]} y fue puntuado por: '{nombres[0]}'");
        }

        static void MostrarMayorPuntaje(int[] calif, string[] nombres)
        {
            OrdenarBurbuja(calif, nombres, true);

            Console.WriteLine($"El mayor puntaje es: {calif[calif.Length - 1]} y fue puntuado por: '{nombres[nombres.Length-1]}'.");
        }

        static void MostrarSiHuboDuplicados(int[] calif, string[] nombres)
        {
            OrdenarBurbuja(calif, nombres, true);

            bool duplicados = false;
            
            for (int i = 0; i < calif.Length - 1; i++)
            {
                if (calif[i] == calif[i + 1])
                {
                    duplicados = true;
                }
            }
            
            if ( duplicados)
            {
                Console.WriteLine("Hay calificaciones duplicadas");
            }
            else
            {
                Console.WriteLine("No hay calificaciones duplicadas");
            }
        }
        static void Main(string[] args)
        {
            int[] aCalificaciones = new int[15] {5,6,8,9,10,9,5,7,3,6,5,10,10,8,1 }            ;
            string[] aNombres = new string[15] {"pepe", "pepito", "juan", "maria","Pedro", "Julian", "Franco", "Clara", "Clarisa","Juliana", "Ricardo", "Mateo", "damian", "Juan","Martin" };

            string opcion;
            do
            {
                MostrarMenu();
                opcion = Console.ReadLine();
                
                switch (opcion)
                {
                    case "1":
                        Cargar(aCalificaciones, aNombres);
                        break;
                    case "2":
                        MostrarMenorPuntaje(aCalificaciones, aNombres);
                        break;
                    case "3":
                        MostrarMayorPuntaje(aCalificaciones, aNombres);
                        break;
                    case "4":
                        MostrarSiHuboDuplicados(aCalificaciones, aNombres);
                        break;
                    case "5":
                        MostrarListado(aCalificaciones, aNombres);
                        break;
                    case "6":
                        OrdenarBurbuja(aCalificaciones,  aNombres, true);
                        break;
                    case "7":
                        OrdenarBurbuja( aCalificaciones,  aNombres, false);
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (opcion != "0");
        }
    }
}
