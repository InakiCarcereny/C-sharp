namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] invitados;
            int cantidad = 0;

            invitados = new string[10];

            while (true)
            {
                Console.Write($"Ingrese el nombre del invitado {cantidad + 1} (o 'salir' para terminar): ");
                string entrada = Console.ReadLine().ToLower();

                if (entrada == "salir")
                {
                    break;
                }

                if (cantidad == invitados.Length)
                {
                    string[] nuevo = new string[invitados.Length + 10];

                    for (int i = 0; i < invitados.Length; i++)
                    {
                        nuevo[i] = invitados[i];
                    }

                    invitados = nuevo;
                }

                invitados[cantidad] = entrada;
                cantidad++;
            }

            string[] final = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                final[i] = invitados[i];
            }

            Console.WriteLine($"Cantidad total de invitados: {cantidad}");

            Console.WriteLine("Lista de invitados:");
            
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"- {final[i]}");
            }
        }
    }
}
