namespace sum_two_numbers
{
    internal class Program
    {
        static bool EsBisiesto(int anio)
        {
            return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
        }
        static void Main(string[] args)
        {
            bool es_bisiesto;

            es_bisiesto = EsBisiesto(2024);

            if (es_bisiesto)
            {
                Console.WriteLine("Es bisiesto");
            }
            else
            {
                Console.WriteLine("NO es bisiesto");
            }
        }
    }
}
