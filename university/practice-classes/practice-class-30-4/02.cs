namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] gastos;

            bool exito;

            double promedio,
                   suma;

            int contador;

            gastos = new double[7];

            promedio = 0;
            suma = 0;
            contador = 0;

            for (int i = 0; i < gastos.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el gatos del dia {i + 1}");
                    exito = double.TryParse( Console.ReadLine(), out gastos[i]);
                } while (!exito || gastos[i] < 0);

                suma += gastos[i];
            }

            promedio = suma / gastos.Length;

            for (int i = 0; i < gastos.Length; i++)
            {
                if (gastos[i] > promedio)
                {
                    contador++;
                }
            }

            Console.WriteLine($"{contador} dias superaron al promedio");
        }
    }
}
