namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,
                b,
                x;

            bool exito,
                 hay_multiplo;

            a = 0;
            b = 0;
            x = 0;

            exito = false;
            hay_multiplo = false;

            while (exito == false)
            {
                Console.WriteLine("Ingrese un valor entero y positivo");
                exito = int.TryParse(Console.ReadLine(), out a) && a > 0;
            }

            exito = false;

            while (exito == false)
            {
                Console.WriteLine("Ingrese un valor entero y positivo");
                exito = int.TryParse(Console.ReadLine(), out b) && b > 0;
            }

            exito = false;

            while (exito == false)
            {
                Console.WriteLine("Ingrese un valor entero y positivo");
                exito = int.TryParse(Console.ReadLine(), out x) && x > 0;
            }

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine($"El numero {i} es multiplo de {x} y esta entre {a} y {b}");
                        hay_multiplo = true;
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine($"El numero {i} es multiplo de {x} y esta entre {a} y {b}");
                        hay_multiplo = true;
                    }
                }
            }

            if (!hay_multiplo)
            {
                Console.WriteLine($"No se encontraron múltiplos de {x} entre {a} y {b}");
            }
        }
    }
}
