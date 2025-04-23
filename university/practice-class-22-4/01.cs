namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            string numero;

            char digito_actual;

            contador = 0;

            Console.WriteLine("Ingrese un numero");
            numero = Console.ReadLine();

            for (int i = 0; i <= numero.Length - 1; i++)
            {
                digito_actual = numero[i];

                Console.WriteLine($"El digito es {digito_actual}");

                contador = contador + Convert.ToInt32(digito_actual.ToString());
            }

            Console.WriteLine($"La suma total de los digitos es {contador}");
        }
    }
}
