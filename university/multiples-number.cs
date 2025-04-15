namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio,
                tope,
                contador,
                num;

            contador = 0;

            Console.WriteLine("Ingrese un inicio");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un tope");
            tope = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            while (inicio <= tope)
            {               
                if (inicio % num == 0)
                {
                    contador++;
                }

                Console.WriteLine($"El numero actual es: {inicio}");
                
                inicio++;
            }

            Console.WriteLine($"El total de numeros multiplos es: {contador}");
        }
    }
}
