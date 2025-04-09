namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char clase_social;
            int costo_tratamiento;

            Console.WriteLine("Ingrese el costo del tratamiento");
            costo_tratamiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique la clase social que tiene");
            clase_social = Convert.ToChar(Console.ReadLine());


            switch (clase_social)
            { 
                case 'a':
                    Console.WriteLine($"El costo total es ${(costo_tratamiento * 50) / 100}");
                    break;

                case 'b':
                    Console.WriteLine($"El costo total es ${(costo_tratamiento * 35) / 100}");
                    break;

                case 'c':
                    Console.WriteLine($"El costo total es ${costo_tratamiento}");
                    break;

                default:
                    Console.WriteLine("No es socio");
                    break;
            }
        }
        
    }
}
