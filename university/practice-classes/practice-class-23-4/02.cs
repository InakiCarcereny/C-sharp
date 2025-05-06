namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salario_ingresado,
                salario_extra,
                salario_final;

            bool exito;

            string respuesta;

            salario_final = 0;

            do
            {
                Console.WriteLine("Ingrese un salario");
                exito = int.TryParse(Console.ReadLine(), out salario_ingresado);

                if (salario_ingresado > 0 && salario_ingresado < 900000)
                {
                    salario_extra = (15 * salario_ingresado) / 100;
                    salario_final = salario_ingresado + salario_extra;
                }

                if (salario_ingresado > 900000 && salario_ingresado < 1350000 )
                {
                    salario_extra = (10 * salario_ingresado) / 100;
                    salario_final = salario_ingresado + salario_extra;
                }

                if (salario_ingresado > 1350000 && salario_ingresado < 1750000)
                {
                    salario_extra = (7 * salario_ingresado) / 100;
                    salario_final = salario_ingresado + salario_extra;
                }

                if (salario_ingresado > 1750000)
                {
                    salario_extra = (5 * salario_ingresado) / 100;
                    salario_final = salario_ingresado + salario_extra;
                }

                Console.WriteLine($"El salario final es ${salario_final}");

                Console.WriteLine("Desea calcular un nuevo sueldo?");
                respuesta = Console.ReadLine();

            } while (!exito || respuesta.ToLower() == "si");
            
        }
    }
}
