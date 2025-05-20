namespace sum_two_numbers
{
    internal class Program
    {
        static int Invertir(int numero)
        {
            int invertido = 0;
            while (numero > 0)
            {
                invertido = invertido * 10 + (numero % 10);
                numero = numero / 10;
            }
            return invertido;
        }

        static void Main(string[] args)
        {
            int numero,
                numero_invertido;

            bool exito;

            do
            {
                Console.WriteLine("ingrese un numero");
                exito = int.TryParse(Console.ReadLine(), out numero);
            } while (!exito);

            numero_invertido = Invertir(numero);

            if (numero == numero_invertido)
            {
                Console.WriteLine($"el numero {numero} es capicua");
            }
            else
            {
                Console.WriteLine($"el numero {numero} NO es capicua");
            }
        }
    }
}
