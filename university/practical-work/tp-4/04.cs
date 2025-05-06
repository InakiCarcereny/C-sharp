namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            bool exito;

            exito = false;
            numero = 0;

            while (exito == false)
            {
                Console.WriteLine("Ingrese un numero");
                exito = int.TryParse(Console.ReadLine(), out numero) && numero > 0;
            }

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine($"El numero {i} es divisor de {numero}");
                }
            }
        }
    }
}
