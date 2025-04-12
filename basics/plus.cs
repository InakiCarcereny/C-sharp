static void Main(string[] args)
{
    int num1,
    num2;

    Console.Write("Ingrese el primer numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el segundo numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"La suma es {num1 + num2}");
}