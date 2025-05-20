namespace sum_two_numbers
{
    internal class Program
    {
        static bool EsDigito(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            bool es_digito;

            char c;

            string respuesta;

            do
            {
                Console.WriteLine("Ingrese un caracter");
                c = Convert.ToChar(Console.ReadLine());

                es_digito = EsDigito(c);
                Console.WriteLine($"{es_digito}");

                Console.WriteLine("Desea probar otro caracter?");
                respuesta = Console.ReadLine();
            } while (respuesta.ToLower() == "si");
        }
    }
}
