namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int litros_ingresados,
                litros_actuales,
                tambores_200litros,
                tambores_4litros,
                tambores_1litro;

            string respuesta;

            bool exito;

            litros_actuales = 0;
            tambores_200litros = 0;
            tambores_4litros = 0;
            tambores_1litro = 0;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese cuantos litros necesita");
                    exito = int.TryParse(Console.ReadLine(), out litros_ingresados);
                } while (!exito || litros_ingresados < 1);

                litros_actuales = litros_actuales + litros_ingresados;
                Console.WriteLine("Quiere solicitar mas litros?");
                respuesta = Console.ReadLine();

            } while (respuesta.ToLower() == "si");

            while (litros_actuales >= 200)
            {
                tambores_200litros++;
                litros_actuales -= 200;
            }

            while (litros_actuales >= 4)
            {
                tambores_4litros++;
                litros_actuales -= 4;
            }

            while (litros_actuales >= 1)
            {
                tambores_1litro++;
                litros_actuales -= 1;
            }

            Console.WriteLine($"La cantidad de bidones de 200 l es {tambores_200litros}");
            Console.WriteLine($"La cantidad de bidones de 4 l es {tambores_4litros}");
            Console.WriteLine($"La cantidad de bidones de 1 l es {tambores_1litro}");
        }
    }
}
