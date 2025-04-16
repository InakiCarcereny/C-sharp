namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            bool exito;

            exito = false;
            numero = 0; //El compilador en VS Community me obliga a inicializar la variable

            while (exito == false)
            {
                Console.WriteLine("Ingrese un numero positivo y entero");
                exito = int.TryParse(Console.ReadLine(), out numero) && numero > 0;
            }

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"El numero actual es: {i}");
            }
        }
    }
}
