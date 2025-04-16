namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dm,
                   metros_a_pulgadas,
                   pulgadas_a_pies;

            const double PULGADAS = 39.37;

            Console.WriteLine("Ingrese una distancia");
            dm = Convert.ToDouble(Console.ReadLine());

            metros_a_pulgadas = dm * PULGADAS;
            pulgadas_a_pies = metros_a_pulgadas / 12;

            Console.WriteLine($"{dm}M en pies es {(int)pulgadas_a_pies} pies");
        }
    }
}
