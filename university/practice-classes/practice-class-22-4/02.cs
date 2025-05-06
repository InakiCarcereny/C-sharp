namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parcial1,
                parcial2,
                promedio;

            Console.WriteLine("Ingrese una nota");
            parcial1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una segunda nota");
            parcial2 = int.Parse(Console.ReadLine());

            promedio = (parcial1 + parcial2) / 2;

            if (parcial1 < 80 || parcial2 < 80)
            {
                Console.WriteLine("Usted aprobo el cursado pero tiene que rendir el final");
            }
            else
            {
                if (promedio >= 80)
                {
                    Console.WriteLine("Usted promociono la materia");
                }
            }

            if (parcial1 < 60 || parcial2 < 60)
            {
                Console.WriteLine("Usted debe recursar ya que desaprobo uno de los parciales");

            }
            else
            {
                if (promedio >= 60 && promedio < 80)
                {
                    Console.WriteLine("Usted aprobo el cursado pero tiene que rendir el final");
                }
            }
        }
    }
}
