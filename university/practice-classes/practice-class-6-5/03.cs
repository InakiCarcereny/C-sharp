namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista1,
                  lista2,
                  numeros_intersectados;

            int cantidad_numeros_lista1,
                cantidad_numeros_lista2,
                numero_actual_lista,
                longitud_arreglo;

            bool exito;

            do
            {
                Console.WriteLine("Ingrese cuanto numeros quiere en la lista 1");
                exito = int.TryParse(Console.ReadLine(), out cantidad_numeros_lista1);
            } while (!exito || cantidad_numeros_lista1 <= 0);

            lista1 = new int[cantidad_numeros_lista1];

            do
            {
                Console.WriteLine("Ingrese cuanto numeros quiere en la lista 2");
                exito = int.TryParse(Console.ReadLine(), out cantidad_numeros_lista2);
            } while (!exito || cantidad_numeros_lista2 <= 0);

            lista2 = new int[cantidad_numeros_lista2];

            for (int i = 0; i < lista1.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el numero {i + 1} de la lista 1");
                    exito = int.TryParse(Console.ReadLine(), out lista1[i]);
                } while (!exito || lista1[i] < 0);
            }

            for (int i = 0; i < lista2.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el numero {i + 1} de la lista 2");
                    exito = int.TryParse(Console.ReadLine(), out lista2[i]);
                } while (!exito || lista2[i] < 0);
            }

            numero_actual_lista = lista1[0];

            if (lista1.Length > lista2.Length)
            {
                longitud_arreglo = lista1.Length;
            }
            else
            {
                longitud_arreglo = lista2.Length;
            }

            numeros_intersectados = new int[longitud_arreglo];

            for (int i = 0; i < lista1.Length; i++)
            {
                numero_actual_lista = lista1[i];

                for (int j = 0; j < lista2.Length; j++)
                {
                    if (numero_actual_lista == lista2[j])
                    {
                        numeros_intersectados[i] = numero_actual_lista;
                    }
                }
            }

            Console.WriteLine("El arreglo con los numeros intersectados queda asi");

            for (int i = 0; i < numeros_intersectados.Length; i++)
            {
                Console.Write($"{numeros_intersectados[i]}" + " ");
            }
        }
    }
}
