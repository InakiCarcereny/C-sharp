namespace sum_two_numbers
{
    internal class Program
    {
        public struct Casa
        {
            public double temperatura;
            public int iluminacion_interior;
            public bool iliminacion_exterior;
        }

        static void AjustarTemperatura()
        {
            bool exito;

            double temperatura_actual;

            Casa mi_casa;

            do
            {
                Console.WriteLine("Ingrese la temperatura que desea");
                exito = double.TryParse(Console.ReadLine(), out temperatura_actual);
            } while (!exito || temperatura_actual < 20.0 || temperatura_actual > 25.5);

            mi_casa.temperatura = temperatura_actual;
        }

        static void AjustarIluminacionInterior()
        {
            bool exito;

            int iluminacion_interior_actual;

            Casa mi_casa;

            do
            {
                Console.WriteLine("Ingrese la iluminacion");
                exito = int.TryParse(Console.ReadLine(), out iluminacion_interior_actual);
            } while (!exito || iluminacion_interior_actual < 0 || iluminacion_interior_actual > 100);

            mi_casa.iluminacion_interior = iluminacion_interior_actual;
        }

        static void AjustarIluminacionExterior()
        {
            string respuesta;

            Casa mi_casa;

            Console.WriteLine("Ingrese [V] para prendido, [F] para apagado");
            respuesta = Console.ReadLine();

            if (respuesta == "V")
            {
                mi_casa.iliminacion_exterior = true;
            }
            else
            {
                mi_casa.iliminacion_exterior = false;
            }
        }

        static void VerConfig()
        {
            Casa mi_casa;

            Console.WriteLine("La configuracion actual es:");
            Console.WriteLine($"Temperatura: {mi_casa.temperatura}");
            Console.WriteLine($"Iluminacion interior: {mi_casa.iluminacion_interior}");
            Console.WriteLine($"Iluminacion exterior: {mi_casa.iliminacion_exterior}");
        }
        static void Main(string[] args)
        {
            AjustarTemperatura();
            AjustarIluminacionInterior();
            AjustarIluminacionExterior();
            VerConfig();
        }
    }
}
