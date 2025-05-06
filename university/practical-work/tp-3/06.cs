namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado_cuadrado;

            int opcion;

            Console.WriteLine("Ingrese el lado de un cuadrado");
            lado_cuadrado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese una opcion, 1 para perimetro, 2 para area");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine($"El perimetro del cuadrado es {lado_cuadrado * 4}");
            }

            if (opcion == 2)
            {
                Console.WriteLine($"El area del cuadrado es {lado_cuadrado * lado_cuadrado}");
            }
        }
    }
}
