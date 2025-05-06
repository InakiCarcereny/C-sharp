namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador,
                longitud_palabra_actual,
                longitud_palabra_nueva;

            string palabra_actual,
                   palabra_nueva,
                   frase;

            contador = 0;
            longitud_palabra_nueva = 0;

            palabra_actual = "";
            palabra_nueva = "";

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                contador++;
                palabra_actual += frase[i];

                if ((int)frase[i] == 32)
                {
                    longitud_palabra_actual = contador - 1;

                    if (longitud_palabra_actual > longitud_palabra_nueva)
                    {
                        palabra_nueva = palabra_actual;
                        longitud_palabra_nueva = longitud_palabra_actual;
                    }

                    contador = 0;
                    palabra_actual = "";
                }
            }

            if (contador > longitud_palabra_nueva)
            {
                palabra_nueva = palabra_actual;
                longitud_palabra_nueva = contador;
            }

            Console.WriteLine($"La palabra mas larga es {palabra_nueva} y tiene {longitud_palabra_nueva} caracteres");
        }
    }
}
