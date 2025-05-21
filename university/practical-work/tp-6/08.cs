namespace sum_two_numbers //Con funciones
{
  internal class Program
  {
    static string Reverso(ref string texto)
    {
      string palabra_revez;

      palabra_revez = "";

      for (int i = texto.Length - 1; i >= 0; i--)
      {
        palabra_revez += texto[i];
      }

      return palabra_revez;
    }

    static bool EsPalindromo(string texto, string palabra_revez)
    {
      if (texto == palabra_revez)
      {
        return true;
      }

      return false;
    }
    static void Main(string[] args)
    {
      string texto,
             palabra_revez;

      bool es_palindromo;

      Console.WriteLine("Ingrese una palabra");

      texto = Console.ReadLine().ToLower();

      palabra_revez = Reverso(ref texto);

      es_palindromo = EsPalindromo(texto, palabra_revez);

      Console.WriteLine($"La palabra al revez es: {palabra_revez}");

      if (es_palindromo)
      {
        Console.WriteLine($"La palabra {texto} es palindromo");
      }
      else
      {
        Console.WriteLine($"La palabra {texto} NO es palindromo");
      }
    }
  }
}

namespace sum_two_numbers //Con procedimientos
{
    internal class Program
    {
        static string palabra_revez = "";
        static void Reverso(ref string texto)
        {
            for (int i = texto.Length - 1; i >= 0; i--)
            {
                palabra_revez += texto[i];
            }

            Console.WriteLine($"La palabra al revez es: {palabra_revez}");
        }

        static void EsPalindromo(string texto)
        {
            if (texto == palabra_revez)
            {
                Console.WriteLine($"La palabra {texto} es palindromo");
            }
            else
            {
                Console.WriteLine($"La palabra {texto} NO es palindromo");
            }
        }
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Ingrese una palabra");

            texto = Console.ReadLine().ToLower();

            Reverso(ref texto);

            EsPalindromo(texto);
        }
    }
}

