namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura,
                numero_actual;

            bool exito;

            exito = false;
            altura = 0;
            numero_actual = 0;

            while (!exito || altura < 1)
            {
                Console.WriteLine("Ingrese una altura para la piramide");
                exito = int.TryParse(Console.ReadLine(), out altura);
            }


            for (int i = 1; i <= altura; i++)
            {
                for (int j = altura - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write('*');
                    numero_actual = k;
                }

                for (int l = numero_actual - 1; l >= 1; l--)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
