namespace sum_two_numbers
{
    internal class Program
    {
        public struct Alumno
        {
            public int legajo;
            public string apellido;
            public string nombre;
            public double nota;
        }

        static void OrdenarPorApellido(ref Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length - 1; i++)
            {
                for (int j = 0; j < alumnos.Length - i - 1; j++)
                {
                    if (string.Compare(alumnos[j].apellido, alumnos[j + 1].apellido) > 0)
                    {
                        Alumno aux = alumnos[j];
                        alumnos[j] = alumnos[j + 1];
                        alumnos[j + 1] = aux;
                    }
                }
            }
        }

        static void CargarAlumnos(ref Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine($"Alumno {i + 1}");

                Console.Write("Legajo: ");
                alumnos[i].legajo = int.Parse(Console.ReadLine());

                Console.Write("Apellido: ");
                alumnos[i].apellido = Console.ReadLine();

                Console.Write("Nombre: ");
                alumnos[i].nombre = Console.ReadLine();

                Console.Write("Nota: ");
                alumnos[i].nota = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }

        static void MostrarAlumnos(Alumno[] alumnos)
        {
            Console.WriteLine("--- Lista de alumnos ordenada por apellido ---");

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine($"Legajo: {alumnos[i].legajo}, Apellido: {alumnos[i].apellido}, Nombre: {alumnos[i].nombre}, Nota: {alumnos[i].nota}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos alumnos desea cargar? ");
            int cantidad = int.Parse(Console.ReadLine());

            Alumno[] alumnos = new Alumno[cantidad];

            CargarAlumnos(ref alumnos);
            OrdenarPorApellido(ref alumnos);
            MostrarAlumnos(alumnos);
        }
    }
}
