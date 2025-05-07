namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas;

            int cantidad_notas,
                nota_mas_alta,
                nota_mas_baja,
                indice_alta,
                indice_baja;

            bool exito;

            indice_alta = 0;
            indice_baja = 0;

            do
            {
                Console.WriteLine("Ingrese cuantas notas quiere ingresar");
                exito = int.TryParse(Console.ReadLine(), out cantidad_notas);
            } while (!exito);

            notas = new int[cantidad_notas];

            for (int i = 0; i < notas.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese la nota {i + 1}");
                    exito = int.TryParse(Console.ReadLine(), out notas[i]);
                } while (!exito);
            }

            nota_mas_alta = notas[0];
            nota_mas_baja = notas[0];

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > nota_mas_alta)
                {
                    nota_mas_alta = notas[i];
                    indice_alta = i;
                }
                else
                {
                    nota_mas_baja = notas[i];
                    indice_baja = i;
                }
            }

            Console.WriteLine($"La nota mas alta es {nota_mas_alta} y se encuentra en la posicion {indice_alta}");
            Console.WriteLine($"La nota mas baja es {nota_mas_baja} y se encuentra en la posicion {indice_baja}");
        }
    }
}
