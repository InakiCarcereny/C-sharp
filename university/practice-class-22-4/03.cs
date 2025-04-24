namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double costo_metros;
            int metros;
            string respuesta;
            bool exito;

            do
            {
                do
                {
                    Console.WriteLine("Cuantos metros cubicos de agua consumio?");
                    exito = int.TryParse(Console.ReadLine(), out metros);
                } while (!exito || metros < 1);

                if (metros >= 1 && metros <= 20)
                {
                    costo_metros = metros * 3.20;
                    Console.WriteLine($"Su consumo fue de ${costo_metros + 3000}");
                }
                else if (metros >= 21 && metros <= 40)
                {
                    costo_metros = metros * 5.30;
                    Console.WriteLine($"Su consumo fue de ${costo_metros + 3000}");
                }
                else if (metros >= 41 && metros <= 60)
                {
                    costo_metros = metros * 6.40;
                    Console.WriteLine($"Su consumo fue de ${costo_metros + 5000}");
                }
                else
                {
                    costo_metros = metros * 7.50;
                    Console.WriteLine($"Su consumo fue de ${costo_metros + 6000}");
                }

                Console.WriteLine("Desea calcular otra vez");
                respuesta = Console.ReadLine();

            } while (respuesta.ToLower() == "si");
        }
    }
}
