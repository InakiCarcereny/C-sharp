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
                tambores_1litro,
                total_tambores_200litros,
                total_tambores_4litros,
                total_tambores_1litro,
                cantidad_total_tambores;

            string respuesta;

            bool exito;

            total_tambores_1litro = 0;
            total_tambores_4litros = 0;
            total_tambores_200litros = 0;

            do
            {
                tambores_200litros = 0;
                tambores_4litros = 0;
                tambores_1litro = 0;
                litros_actuales = 0;

                do
                {
                    Console.WriteLine("Ingrese cuantos litros necesita");
                    exito = int.TryParse(Console.ReadLine(), out litros_ingresados);
                } while (!exito || litros_ingresados < 1);

                litros_actuales = litros_ingresados;

                while (litros_actuales >= 200)
                {
                    tambores_200litros++;
                    litros_actuales -= 200;

                    total_tambores_200litros++;
                }

                while (litros_actuales >= 4)
                {
                    tambores_4litros++;
                    litros_actuales -= 4;

                    total_tambores_4litros++;
                }

                while (litros_actuales >= 1)
                {
                    tambores_1litro++;
                    litros_actuales -= 1;

                    total_tambores_1litro++;
                }

                Console.WriteLine($"La cantidad de bidones de 200 l es {tambores_200litros}");
                Console.WriteLine($"La cantidad de bidones de 4 l es {tambores_4litros}");
                Console.WriteLine($"La cantidad de bidones de 1 l es {tambores_1litro}");

                Console.WriteLine("Quiere solicitar mas litros?");
                respuesta = Console.ReadLine();

            } while (respuesta.ToLower() == "si");

            cantidad_total_tambores = total_tambores_1litro + total_tambores_200litros + total_tambores_4litros;

            Console.WriteLine($"La cantidad total de tambores es {cantidad_total_tambores} y hay:");
            Console.WriteLine($"{total_tambores_200litros} de 200L");
            Console.WriteLine($"{total_tambores_4litros} de 4L");
            Console.WriteLine($"{total_tambores_1litro} de 1L");
        }
    }
}
