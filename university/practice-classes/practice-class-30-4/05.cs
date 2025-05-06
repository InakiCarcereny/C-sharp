namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] votos;

            bool exito;

            const int CANTIDAD_VOTOS = 20;

            int cantidad_votos_1,
                cantidad_votos_2,
                cantidad_votos_3,
                cantidad_votos_4,
                cantidad_votos_5;

            votos = new int[CANTIDAD_VOTOS];

            cantidad_votos_1 = 0;
            cantidad_votos_2 = 0;
            cantidad_votos_3 = 0;
            cantidad_votos_4 = 0;
            cantidad_votos_5 = 0;

            for (int i = 0; i < votos.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el voto {i + 1}. Tiene que ser entre 1 y 5 inclusives");
                    exito = int.TryParse(Console.ReadLine(), out votos[i]);
                } while (!exito || votos[i] < 1 || votos[i] > 5);

                if (votos[i] == 1)
                {
                    cantidad_votos_1++;
                }

                if (votos[i] == 2)
                {
                    cantidad_votos_2++;
                }

                if (votos[i] == 3)
                {
                    cantidad_votos_3++;
                }

                if (votos[i] == 4)
                {
                    cantidad_votos_4++;
                }

                if (votos[i] == 5)
                {
                    cantidad_votos_5++;
                }
            }

            Console.WriteLine($"Cantidad de votos iguales a 1: {cantidad_votos_1}");
            Console.WriteLine($"Cantidad de votos iguales a 2: {cantidad_votos_2}");
            Console.WriteLine($"Cantidad de votos iguales a 3: {cantidad_votos_3}");
            Console.WriteLine($"Cantidad de votos iguales a 4: {cantidad_votos_4}");
            Console.WriteLine($"Cantidad de votos iguales a 5: {cantidad_votos_5}");
        }
    }
}
