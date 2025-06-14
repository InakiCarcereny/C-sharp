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

        static void AjustarTemperatura(ref Casa mi_casa)
        {
            bool exito;
            double temperatura_actual;

            do
            {
                Console.WriteLine("Ingrese la temperatura que desea");
                exito = double.TryParse(Console.ReadLine(), out temperatura_actual);
            } while (!exito || temperatura_actual < 20.0 || temperatura_actual > 25.5);

            mi_casa.temperatura = temperatura_actual;
        }

        static void AjustarIluminacionInterior(ref Casa mi_casa)
        {
            bool exito;
            int iluminacion_interior_actual;

            do
            {
                Console.WriteLine("Ingrese la iluminacion");
                exito = int.TryParse(Console.ReadLine(), out iluminacion_interior_actual);
            } while (!exito || iluminacion_interior_actual < 0 || iluminacion_interior_actual > 100);

            mi_casa.iluminacion_interior = iluminacion_interior_actual;
        }

        static void AjustarIluminacionExterior(ref Casa mi_casa)
        {
            string respuesta;

            Console.WriteLine("Ingrese [V] para prendido, [F] para apagado");
            respuesta = Console.ReadLine();

            mi_casa.iliminacion_exterior = (respuesta.ToUpper() == "V");
        }

        static void VerConfig(Casa mi_casa)
        {
            Console.WriteLine("La configuracion actual es:");
            Console.WriteLine($"Temperatura: {mi_casa.temperatura}");
            Console.WriteLine($"Iluminacion interior: {mi_casa.iluminacion_interior}");
            Console.WriteLine($"Iluminacion exterior: {mi_casa.iliminacion_exterior}");
        }

        static void Main(string[] args)
        {
            Casa mi_casa = new Casa();

            AjustarTemperatura(ref mi_casa);
            AjustarIluminacionInterior(ref mi_casa);
            AjustarIluminacionExterior(ref mi_casa);
            VerConfig(mi_casa);
        }
    }
}
