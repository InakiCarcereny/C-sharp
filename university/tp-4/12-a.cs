namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Ingrese una oracion de su gusto");
            texto = Console.ReadLine();

            Console.WriteLine($"El numero total de caracteres es {texto.Length}");
        }
    }
}
