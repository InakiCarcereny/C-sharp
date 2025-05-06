namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;

            int contador;

            contador = 0;

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if ((int)frase[i] == 32)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Hay {contador + 1} palabras separadas por espacio");
        }
    }
}
