namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroTexto = Console.ReadLine();
            int numero;

            bool exito = int.TryParse(numeroTexto, out numero);

            if (exito)
            {
                Console.WriteLine("Número convertido correctamente: " + numero);
            }
            else
            {
                Console.WriteLine("No se pudo convertir el texto a número.");
            }

        }
    }
}
