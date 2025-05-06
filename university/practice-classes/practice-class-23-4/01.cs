namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            bool exito;

            string respuesta;

            exito = false;
            numero = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entero mayor a 1 y menor a 10");
                exito = int.TryParse(Console.ReadLine(), out numero);

                Console.WriteLine($"Tabla del {numero}");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                Console.WriteLine("Quiere ver las tablas de otro numero?");
                respuesta = Console.ReadLine();

            } while(!(exito || numero < 1 || numero > 10) || respuesta.ToLower() == "si");
        }
    }
}
