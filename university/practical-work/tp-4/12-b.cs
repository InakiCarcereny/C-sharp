namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            string frase;

            contador = 0;

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if ((frase[i] >= 'A' && frase[i] <= 'Z') || (frase[i] >= 'a' && frase[i] <= 'z'))
                {
                    contador++;
                }
            }

            Console.WriteLine($"La cantidad de letras es {contador}");
        }
    }
}
