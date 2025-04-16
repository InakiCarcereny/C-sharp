namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            int numero;

            numero = 0;

            Console.WriteLine("Ingrese un caracter");
            caracter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Cuantas veces queres que se repita");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.Write($"{caracter}");
            }
        }
    }
}
