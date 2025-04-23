namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase,
                   frase_revez;

            frase_revez = "";

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                frase_revez += frase[i];
            }

            Console.WriteLine($"La frase al revez es: {frase_revez}");
        }
    }
}
