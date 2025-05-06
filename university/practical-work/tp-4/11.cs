namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            string texto;

            char letra;

            contador = 0;

            Console.WriteLine("Ingrese un texto que le guste");
            texto = Console.ReadLine();

            for (int i = 0; i < texto.Length; i++)
            {
                letra = texto[i];

                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    contador++;
                }
            }

            Console.WriteLine($"Aparecen {contador} vocales");
        }
    }
}
