namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1,
                nota2,
                nota3;

            int promedio;

            Console.WriteLine("Ingrese una nota");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otra nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese una ultima nota");
            nota3 = Convert.ToInt32(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 6 && promedio <= 10)
            {
                Console.WriteLine("Cursa y promociona");
            }
            else if (promedio >= 4 && promedio < 6)
            {
                Console.WriteLine("Cursa y rinde examen final");
            }
            else if(promedio < 4)
            {
                Console.WriteLine("No cursa");
            }
        }
        
    }
}
