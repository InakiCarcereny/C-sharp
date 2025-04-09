namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char forma_de_pago;
            double monto_de_la_compra,
                   descuento,
                   total_a_pagar;

            const int DESCUENTO_EFECTIVO = 20;
            const int DESCUENTO_TARJETA = 10;

            Console.WriteLine("Elija su forma de pago E para efectivo, T para tarjeta");
            forma_de_pago = Convert.ToChar(Console.ReadLine());

            forma_de_pago = char.ToUpper(forma_de_pago);

            Console.WriteLine("Ingrese el monto de la compra");
            monto_de_la_compra = Convert.ToDouble(Console.ReadLine());

            switch(forma_de_pago)
            {
                case 'E':
                    descuento = (monto_de_la_compra * DESCUENTO_EFECTIVO) / 100;
                    total_a_pagar = monto_de_la_compra - descuento;

                    Console.WriteLine($"Forma de pago: (E: efectivo, T: tarjeta) {forma_de_pago, 48}");
                    Console.WriteLine($"Monto de la compra: {monto_de_la_compra, 48}");
                    Console.WriteLine($"Descuento: {descuento, 48}");
                    Console.WriteLine($"Total a pagar: {total_a_pagar, 48}");
                    break;

                case 'T':
                    if (monto_de_la_compra >= 25000)
                    {
                        descuento = (monto_de_la_compra * DESCUENTO_TARJETA) / 100;
                        total_a_pagar = monto_de_la_compra - descuento;

                        Console.WriteLine($"Forma de pago: (E: efectivo, T: tarjeta) {forma_de_pago, 48}");
                        Console.WriteLine($"Monto de la compra: {monto_de_la_compra, 48}");
                        Console.WriteLine($"Descuento: {descuento,48}");
                        Console.WriteLine($"Total a pagar: {total_a_pagar, 48}");
                    }
                    else
                    {
                        descuento = 0;
                        total_a_pagar = monto_de_la_compra;

                        Console.WriteLine($"Forma de pago: (E: efectivo, T: tarjeta) {forma_de_pago, 48}");
                        Console.WriteLine($"Monto de la compra: {monto_de_la_compra, 48}");
                        Console.WriteLine($"Descuento: {descuento, 48}");
                        Console.WriteLine($"Total a pagar: {total_a_pagar, 48}");
                    }
                    break;
            }

        }
        
    }
}
