namespace sum_two_numbers
{
    internal class Program
    {
        static int PedirNumeroEntero()
        {
            bool exito;
            int numero_entero;

            do
            {
                Console.WriteLine("Ingrese un numero entero");
                exito = int.TryParse(Console.ReadLine(), out numero_entero);
            } while (!exito);

            return numero_entero;
        }

        static int PedirNumeroEnteroPositivo()
        {
            bool exito;
            int numero_entero;

            do
            {
                Console.WriteLine("Ingrese un numero entero");
                exito = int.TryParse(Console.ReadLine(), out numero_entero);
            } while (!exito || numero_entero < 0);

            return numero_entero;
        }

        static int NumeroDeDosCifras()
        {
            int numero;

            bool exito;

            do
            {
                Console.WriteLine("Ingrese un numero de dos cifras");
                exito = int.TryParse(Console.ReadLine(), out numero);
            } while (!exito || numero < 0 || numero > 99);

            return numero;
        }

        static void IntercambiarValor(int valor1, int valor2)
        {
            valor1 = valor2;
            valor2 = valor1;
        }

        static void IntercambiarReferencia(ref int valor1, ref int valor2)
        {
            int aux;

            aux = valor1;

            valor1 = valor2;
            valor2 = aux;
        }

        static void DescomponerNumero(int numero, out int decena, out int unidad)
        {
            decena = numero / 10;
            unidad = numero % 10;
        }

        static void Main(string[] args)
        {
            //PedirNumeroEntero();
            //PedirNumeroEnteroPositivo();

            //int valor1,
            //    valor2;

            //valor1 = 20;
            //valor2 = 30;

            //Console.WriteLine($"valor 1 = {valor1} - valor 2 = {valor2}");

            //IntercambiarReferencia(ref valor1, ref valor2);

            //Console.WriteLine($"valor 1 = {valor1} - valor 2 = {valor2}");

            int numero;

            numero = NumeroDeDosCifras();

            DescomponerNumero(numero, out int decena, out int unidad);

            Console.WriteLine($"decena = {decena}, unidad = {unidad}");
        }
    }
}
