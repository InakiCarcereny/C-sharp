namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digitos;

            string numero;

            int digito_mayor,
                digito_menor;

            bool exito;

            Console.WriteLine("Ingrese un numero");
            numero = Console.ReadLine();

            digitos = new int[numero.Length];

            for (int i = 0; i < digitos.Length; i++)
            {
                digitos[i] = numero[i] - '0';
            }

            digito_mayor = digitos[0];
            digito_menor = digitos[0];

            for (int i = 0; i < digitos.Length; i++)
            {
                if (digitos[i] >  digito_mayor)
                {
                    digito_mayor = digitos[i];
                }
                
                if (digitos[i] < digito_menor)
                {
                    digito_menor = digitos[i];
                }
            }


            Console.WriteLine(string.Join(",", digitos));

            Console.WriteLine($"El digito mayor es {digito_mayor}");

            Console.WriteLine($"El digito menor es {digito_menor}");
        }
    }
}
