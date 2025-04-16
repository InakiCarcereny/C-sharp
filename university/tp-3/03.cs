namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia,
                mes,
                anio;

            const int DIA_ACTUAL = 9;
            const int MES_ACTUAL = 4;
            const int ANIO_ACTUAL = 2025;


            Console.WriteLine("Ingrese su dia de nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su mes de nacimiento");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su anio de nacimiento");
            anio = Convert.ToInt32(Console.ReadLine());

            if (dia > DIA_ACTUAL || dia < DIA_ACTUAL && mes > MES_ACTUAL)
            {
                Console.WriteLine($"Usted tiene {ANIO_ACTUAL - anio} anios");
            }
            else if (dia == DIA_ACTUAL && mes == MES_ACTUAL)
            {
                Console.WriteLine($"Usted tiene {ANIO_ACTUAL - anio} y le deseo un muy feliz cumpleanios");
            }
            else if (mes < MES_ACTUAL)
            {
                Console.WriteLine($"Usted tiene {(ANIO_ACTUAL - anio) - 1} anios");
            }
        }
        
    }
}
