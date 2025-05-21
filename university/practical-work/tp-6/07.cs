namespace sum_two_numbers
{
    internal class Program
    {
        static void ConvertirSegundos(int numero, out int segundos, out int minutos)
        {
            minutos = numero / 60;
            segundos = numero % 60;

            Console.WriteLine($"La cantidad de segundos son {segundos} y la cantidad de minutos son {minutos}");
        }
        static void Main(string[] args)
        {
            bool exito;

            int numero,
                segundos,
                minutos;

            do
            {
                Console.WriteLine("Ingrese la cantidad de segundos");
                exito = int.TryParse(Console.ReadLine(), out numero);
            } while (!exito);

            ConvertirSegundos(numero, out segundos, out minutos);
        }
    }
}
